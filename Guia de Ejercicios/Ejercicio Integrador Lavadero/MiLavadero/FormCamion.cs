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
    public partial class FormCamion : FormVehiculo
    {
        private Camion camionDelForm;
        public FormCamion()
        {
            InitializeComponent();
            CargarCmbMarca(this.cmbMarca);
            this.cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Vehiculo GetCamionDelForm
        {
            get
            {
                return this.camionDelForm;
            }
        }
        protected override void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            this.camionDelForm = new Camion(float.Parse(this.txtTara.Text), base.txtPatente.Text, byte.Parse(base.txtCantRuedas.Text), (Vehiculo.EMarcas)base.cmbMarca.SelectedItem);
            base.btnAceptarVehiculo_Click(sender, e);
        }
    }
}
