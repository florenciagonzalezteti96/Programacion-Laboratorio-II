using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDelegados
{
    public partial class FrmPpal : Form
    {
        public TestDelegados actualizarNombrePorDelegado;
        public TestDelegados actualizarFotoPorDelegado;
        public TestDelegadosAlumno mostrarAlumnoPorDelegado;

        public FrmPpal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = false;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frm = new frmTestDelegados(this);
            frm.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos(this);
            frm.Show();

            this.actualizarNombrePorDelegado = new TestDelegados(frm.ActualizarNombre);
            this.actualizarFotoPorDelegado = new TestDelegados(frm.ActualizarFoto);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno frm = new frmAltaAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDatosAlumno frm = new FrmDatosAlumno();
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.mostrarAlumnoPorDelegado += new TestDelegadosAlumno(frm.ActualizarFoto);
            frm.Show(this);
        }
    }
}
