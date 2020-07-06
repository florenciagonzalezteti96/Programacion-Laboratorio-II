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
    public partial class FormMoto : FormVehiculo
    {
        private Moto motoDelForm;
        public FormMoto()
        {
            InitializeComponent();
            CargarCmbMarca(this.cmbMarca);
            this.cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Vehiculo GetMotoDelForm
        {
            get
            {
                return this.motoDelForm;
            }
        }
        protected override void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            this.motoDelForm = new Moto(float.Parse(this.txtCilindrada.Text), base.txtPatente.Text, byte.Parse(base.txtCantRuedas.Text), (Vehiculo.EMarcas)base.cmbMarca.SelectedItem);
            base.btnAceptarVehiculo_Click(sender, e);
        }
        
    }
}
