using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaComercioLibreria;

namespace SistemaDeComercio
{
    public partial class ProductoFrm : Form
    {
        Producto productoFrm;

        public ProductoFrm()
        {
            InitializeComponent();
        }
        public ProductoFrm(int tipoDeNombre)//0 para nombre y 1 para codigo
        {
            InitializeComponent();
            this.mtbNombre.BeepOnError = true;
            if (tipoDeNombre == 0)
            {
                this.mtbNombre.AsciiOnly = true;
            }
        }
        public ProductoFrm(Producto producto)//0 para nombre y 1 para codigo
        {
            InitializeComponent();
            this.mtbNombre.Text = producto.NombreProducto;
            this.mtbCantidad.Text = producto.CantidadEnStock.ToString();
            this.mtbPrecio.Text = producto.PrecioDeVenta.ToString();
            this.mtbCosto.Text = producto.CostoDeProducto.ToString();
        }

        public Producto ProductoNuevo
        {
            get
            {
                return this.productoFrm;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.productoFrm = new Producto(this.mtbNombre.Text, Convert.ToDouble(this.mtbPrecio.Text), Convert.ToDouble(this.mtbCosto.Text), Convert.ToInt32(this.mtbCantidad.Text));

            this.DialogResult = MessageBox.Show("Esta seguro que desea agregar el producto a la lista de stock?", "Confirmacion", MessageBoxButtons.YesNo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoFrm_FormClosing(object sender, FormClosingEventArgs e)
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
