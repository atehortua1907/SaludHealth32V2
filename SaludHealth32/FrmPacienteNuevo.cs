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
using SaludHealth32.BackEnd.DAC;
using Fwk.HelperFunctions;
using Fwk.Exceptions;


namespace SaludHealth32.FrontEnd
{
    public partial class FrmPacienteNuevo : Form
    {
        public FrmPacienteNuevo()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void txtNumref_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                lblError.Text = "Solo se aceptan numeros";
                this.lblError.BackColor = Color.Red;
            }

            // Solo acepta numeros
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void txtNumref_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            PacienteBE wCrearPaciente = new PacienteBE();
            wCrearPaciente.Numref = Convert.ToInt32(txtNumref.Text);
            wCrearPaciente.Nombre = txtNombre.Text;
            wCrearPaciente.Apellidos = txtApellidos.Text;
            wCrearPaciente.Documento = cmbDocumento.Text;
            wCrearPaciente.NumDocumento = Convert.ToInt32(txtNumDocumento.Text);
            wCrearPaciente.FechaIngreso = dtpFechaIngreso.Text;
            wCrearPaciente.EstadoCivil = cmbEstadoCivil.Text;
            if (rdbHombre.Checked)
            {
                wCrearPaciente.Sexo = "Hombre";
            }
            else
            {
                wCrearPaciente.Sexo = "Mujer";
            }


        }

        private void txtNumref_Leave(object sender, EventArgs e)
        {

            // PacientesDAC.Validacion();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void rdbMujer_Click(object sender, EventArgs e)
        {
        }
    }
}
