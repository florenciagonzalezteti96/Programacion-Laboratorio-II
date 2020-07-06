using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiLavadero
{
    public partial class FormVehiculo : Form
    {
        #region atributos
        private Vehiculo vehiculoCreado;
        #endregion

        #region constructor / propiedades
        public FormVehiculo()
        {
            InitializeComponent();
        }
        public Vehiculo GetEmpleadoForm
        {
            get
            {
                return this.vehiculoCreado;
            }
        }
        #endregion

        #region eventos
        protected virtual void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            this.vehiculoCreado = new Vehiculo(txtPatente.Text.ToString(), Convert.ToByte(txtCantRuedas.Text), (Vehiculo.EMarcas)this.cmbMarca.SelectedItem);
            ///agregar messagebox pidiendo confirmacion, mostrando datos.
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancelarVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormVehiculo_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion
        protected void CargarCmbMarca(ComboBox cmb)
        {
            /*foreach (Vehiculo.EMarcas item in Enum.GetValues(typeof(Vehiculo.EMarcas)))
            {
                cmb.Items.Add(item);
            }*/
            cmb.DataSource = Enum.GetValues(typeof(Vehiculo.EMarcas));
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        protected virtual void Modificar(Vehiculo unVehiculo) { }

    }
}
