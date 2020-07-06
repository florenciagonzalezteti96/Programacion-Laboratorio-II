using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDelegados
{
    public partial class frmDatos : Form
    {
        public frmDatos(FrmPpal dueño)
        {
            InitializeComponent();
            this.Owner = dueño;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        public void ActualizarNombre(String nombre)
        {
            this.lblFrmDatos.Text = nombre;
        }

        public void ActualizarFoto(String foto)
        {
            this.pbFrmDatos.ImageLocation = foto;
        }

    }
}
