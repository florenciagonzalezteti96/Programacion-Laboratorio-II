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
    public partial class frmTestDelegados : Form
    {
        private string rutaImagen;
        public frmTestDelegados(FrmPpal dueño)
        {
            InitializeComponent();
            this.Owner = dueño;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ConfigurarSaveFileDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmPpal frmPpal = (FrmPpal)Owner;
            frmPpal.actualizarNombrePorDelegado.Invoke(this.txtFrmTestDelegados.Text);
            frmPpal.actualizarFotoPorDelegado.Invoke(this.rutaImagen);
        }
        
        private void ConfigurarSaveFileDialog()
        {
            this.ofdFrmTest.DefaultExt = ".jpg";
            this.ofdFrmTest.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.ofdFrmTest.Multiselect = false;
            this.ofdFrmTest.Title = "Seleccione una foto...";
            this.ofdFrmTest.RestoreDirectory = true;
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {

            if(this.ofdFrmTest.ShowDialog() == DialogResult.OK)
            {
                if (this.ofdFrmTest.CheckPathExists)
                {
                    if (this.ofdFrmTest.CheckFileExists)
                    {
                        this.rutaImagen = this.ofdFrmTest.FileName;
                    }
                }
            }
            
        }
    }
}
