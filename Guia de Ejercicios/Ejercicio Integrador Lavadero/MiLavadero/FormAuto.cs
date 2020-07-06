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
    public partial class FormAuto : FormVehiculo
    {
        private Auto autoDelForm;
        public FormAuto()
        {
            InitializeComponent();
            CargarCmbMarca(this.cmbMarca);
            this.cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Vehiculo GetAutoDelForm
        {
            get
            {
                return this.autoDelForm;
            }
        }
        protected override void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            this.autoDelForm = new Auto(int.Parse(this.txtCantAsientos.Text), base.txtPatente.Text, byte.Parse(base.txtCantRuedas.Text), (Vehiculo.EMarcas)base.cmbMarca.SelectedItem);
            base.btnAceptarVehiculo_Click(sender, e);
        }
        protected override void Modificar(Vehiculo unVehiculo)
        {
            FormAuto frm = new FormAuto();
            frm.txtPatente.Text = unVehiculo.GetPatente;
            frm.txtPatente.Enabled = false;
            frm.txtCantRuedas.Text = unVehiculo.GetCantidadRuedas.ToString();
            frm.cmbMarca.Text = unVehiculo.GetMarca.ToString();
            frm.txtCantAsientos = ((Auto)unVehiculo).

            base.Modificar(unVehiculo);
        }


    }
}
