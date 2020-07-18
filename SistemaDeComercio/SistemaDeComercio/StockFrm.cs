using SistemaComercioLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeComercio
{
    public partial class StockFrm : Form
    {
        Stock stock;

        public StockFrm()
        {
            InitializeComponent();
            this.stock = new Stock();
        }

        public Stock miStock
        {
            get
            {
                return this.stock;
            }
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            ProductoFrm nuevoProducto = new ProductoFrm(0);

            if (this.rbCodigoProducto.Checked)
            {
                nuevoProducto = new ProductoFrm(1);
            }
            nuevoProducto.ShowDialog();

            if (nuevoProducto.DialogResult == DialogResult.Yes)
            {
                this.stock += nuevoProducto.ProductoNuevo;
                this.lbStock.Items.Add(nuevoProducto.ProductoNuevo);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if(this.lbStock.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto para modificar de la lista.");
            }
            else
            {
                ProductoFrm producto = new ProductoFrm((Producto)this.lbStock.SelectedItem);

                producto.ShowDialog();

                if (producto.DialogResult == DialogResult.Yes)
                {
                    this.stock.Productos[this.lbStock.SelectedIndex] = producto.ProductoNuevo;
                }
                this.ActualizarListaDeStock(this.stock);
            }
        }
        private void ActualizarListaDeStock(Stock s)
        {
            this.lbStock.Items.Clear();
            foreach(Producto p in s.Productos)
            {
                this.lbStock.Items.Add(p);
            }
        }
    }
}
