using SaludHealth32.FrontEnd;
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


namespace SaludHealth32
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var frm1 = new FrmPacienteNuevo())
            //    {
            //        frm1.MdiParent = this;
            //        frm1.Show();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            //    throw;
            //}

            var frm1 = new FrmPacienteNuevo();
            frm1.MdiParent = this;
            frm1.Show();
            
        }

        private void listadoPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (var frm2 = new FrmListadoPacientes())
            //{
            //    frm2.MdiParent = this;
            //    frm2.Show();
            //}
            var frm1 = new FrmListadoPacientes();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void buscarPacienteIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (var frm3 = new FrmBuscarPacienteId())
            //{
            //    frm3.MdiParent = this;
            //    frm3.Show();
            //}
            var frm1 = new FrmBuscarPacienteId();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void actualizarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (var frm4 = new FrmActualizarPaciente())
            //{
            //    frm4.MdiParent = this;
            //    frm4.Show();
            //}
            var frm1 = new FrmActualizarPaciente();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
