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
using SistemaComercioLibreria;

namespace SistemaDeComercio
{
    public partial class SistemaComercioFrm : Form
    {
        public SistemaComercioFrm()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockFrm stock = new StockFrm();

            stock.ShowDialog();
        }
    }
}
