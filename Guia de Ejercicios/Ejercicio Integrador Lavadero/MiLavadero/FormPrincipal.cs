using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLavadero
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
        private void crearLavaderoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLavadero frm = new FormLavadero(2500, 6500, 8500, "Lavadero Margarita");
            frm.MdiParent = this;
            frm.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = new DialogResult();
            respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
