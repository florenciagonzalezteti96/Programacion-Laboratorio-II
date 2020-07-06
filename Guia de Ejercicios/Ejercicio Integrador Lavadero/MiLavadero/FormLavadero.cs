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
    public partial class FormLavadero : Form
    {
        private Lavadero miLavadero;

        public FormLavadero()
        {
            InitializeComponent();
            miLavadero = new Lavadero(2500, 6500, 8500);
            CargarCmbFacturado(this.CmbFacturado);
            CargarCmbOrdenar(this.CmbOrdenar);
        }
        public FormLavadero(float precioAuto, float precioCamion, float precioMoto, string nombreLavadero)
        {
            InitializeComponent();
            miLavadero = new Lavadero(precioAuto, precioCamion, precioMoto);
            CargarCmbFacturado(this.CmbFacturado);
            CargarCmbOrdenar(this.CmbOrdenar);
            this.lblNombreLavadero.Text = nombreLavadero;
        }
        public Lavadero MiLavadero
        {
            get 
            { 
                return this.miLavadero;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(RBtnAuto.Checked)
            {
                CrearAuto(this);
            }
            if (RBtnCamion.Checked)
            {
                CrearCamion(this);
            }
            if (RBtnMoto.Checked)
            {
                CrearMoto(this);
            }
        }
        private void CrearAuto(FormLavadero frmLavadero)
        {
            FormAuto frmAuto = new FormAuto();
            frmAuto.StartPosition = FormStartPosition.CenterScreen;
            if(frmAuto.ShowDialog() == DialogResult.OK)
            {
                frmLavadero.miLavadero += frmAuto.GetAutoDelForm;
                MostrarLavadero(frmLavadero);
            }
        }
        private void CrearCamion(FormLavadero frmLavadero)
        {
            FormCamion frmCamion = new FormCamion();
            frmCamion.StartPosition = FormStartPosition.CenterScreen;
            if (frmCamion.ShowDialog() == DialogResult.OK)
            {
                frmLavadero.miLavadero += frmCamion.GetCamionDelForm;
                MostrarLavadero(frmLavadero);
            }
        }
        private void CrearMoto(FormLavadero frmLavadero)
        {
            FormMoto frmMoto = new FormMoto();
            frmMoto.StartPosition = FormStartPosition.CenterScreen;
            if (frmMoto.ShowDialog() == DialogResult.OK)
            {
                frmLavadero.miLavadero += frmMoto.GetMotoDelForm;
                MostrarLavadero(frmLavadero);
            }
        }
        private void MostrarLavadero(FormLavadero frmLavadero)
        {
            frmLavadero.ListaVehiculos.Items.Clear();//limpio para que no se repitan los items!
            foreach(Vehiculo item in frmLavadero.miLavadero.GetVehiculo)
            {
                frmLavadero.ListaVehiculos.Items.Add(item.ToString());
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormLavadero_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnEliminarTodos_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = new DialogResult();
            respuesta = MessageBox.Show("¿Esta seguro que desea eliminar todos los vehiculos de la lista?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.ListaVehiculos.Items.Clear();
                this.miLavadero.GetVehiculo.Clear();
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = new DialogResult();
            int indice;

            indice = this.ListaVehiculos.SelectedIndex;

            respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este vehiculo de la lista?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.miLavadero.GetVehiculo.RemoveAt(indice);
                MostrarLavadero(this);
            }
        }
        private void BtnMostrarFacturado_Click(object sender, EventArgs e)
        {
            double totalFacturado = this.miLavadero.MostrarTotalFacturado((Lavadero.EVehiculos)this.CmbFacturado.SelectedItem);
            MessageBox.Show("El total facturado es de: {0:.00}." + totalFacturado, "Total facturado para vehiculos tipo "+this.CmbFacturado.SelectedItem.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarCmbFacturado(ComboBox cmb)
        {
            cmb.DataSource = Enum.GetValues(typeof(Lavadero.EVehiculos));
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCmbOrdenar(ComboBox cmb)
        {
            List<string> listaDeOrdenamientos = new List<string>();
            listaDeOrdenamientos.Add("Ordenar por marca");
            listaDeOrdenamientos.Add("Ordenar por patente");

            cmb.DataSource = listaDeOrdenamientos;
            this.miLavadero.GetVehiculo.Sort(Lavadero.OrdenarVehiculosPorMarca);
        }
        private void CmbOrdenar_TextChanged(object sender, EventArgs e)
        {
            if(this.CmbOrdenar.SelectedIndex == 0)
            {
                this.miLavadero.GetVehiculo.Sort(Lavadero.OrdenarVehiculosPorMarca);
                MostrarLavadero(this);
            }
            else if(this.CmbOrdenar.SelectedIndex == 1)
            {
                this.miLavadero.GetVehiculo.Sort(Lavadero.OrdenarVehiculosPorPatente);
                MostrarLavadero(this);
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = this.miLavadero.GetVehiculo[this.ListaVehiculos.SelectedIndex];
        }
    }
}
