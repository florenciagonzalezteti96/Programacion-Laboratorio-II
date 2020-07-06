using System;
using System.Windows.Forms;
using Entidades;

namespace FormDelegados
{
    public partial class frmAltaAlumno : Form
    {
        public Alumno alumno;

        public frmAltaAlumno()
        {
            InitializeComponent();
            this.ConfigurarOpenFileDialogAlumno();
        }

        private void txtFoto_DoubleClick(object sender, EventArgs e)
        {
            if (this.ofdAlumno.ShowDialog() == DialogResult.OK)
            {
                if (this.ofdAlumno.CheckPathExists)
                {
                    if (this.ofdAlumno.CheckFileExists)
                    {
                        this.txtFoto.Text = this.ofdAlumno.FileName;
                    }
                }
            }
        }

        private void ConfigurarOpenFileDialogAlumno()
        {
            this.ofdAlumno.DefaultExt = ".jpg";
            this.ofdAlumno.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.ofdAlumno.Multiselect = false;
            this.ofdAlumno.Title = "Seleccione una foto...";
            this.ofdAlumno.RestoreDirectory = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.alumno = new Entidades.Alumno(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtDNI.Text), this.txtFoto.Text);

            FrmPpal frm = (FrmPpal)this.MdiParent;

            frm.mostrarAlumnoPorDelegado(this.alumno, new EventArgs());

            this.Close();
        }
    }
}
