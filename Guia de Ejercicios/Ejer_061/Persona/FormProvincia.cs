using EntidadeBaseDeDatos_Provincia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class FormProvincia : Form
    {
        Provincia provinciaIngresada;

        public FormProvincia()
        {
            InitializeComponent();
        }

        public FormProvincia(Provincia p): this()
        {
            this.provinciaIngresada = p;
            this.txtCantidadHabitantes.Text = p.cantidad_habitantes.ToString();
            this.txtNombreProvincia.Text = p.nombre_provincia;
        }

        public Provincia ProvinciaIngresada
        {
            get
            {
                return this.provinciaIngresada;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = 0;
            if(this.provinciaIngresada != null)
            {
                id = this.provinciaIngresada.ID;
            }
            this.provinciaIngresada = new Provincia(id, this.txtNombreProvincia.Text, Convert.ToInt32(this.txtCantidadHabitantes.Text));
            this.DialogResult = DialogResult.OK;
        }
        private void FormProvincia_FormClosing(object sender, FormClosingEventArgs e)
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
