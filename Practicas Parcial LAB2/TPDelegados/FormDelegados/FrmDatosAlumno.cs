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
    public partial class FrmDatosAlumno : frmAltaAlumno
    {
        public FrmDatosAlumno() : base()
        {
            InitializeComponent();
        }

        public void ActualizarFoto(Entidades.Alumno alumno, EventArgs e)
        {
            this.pbDatosAlumno.ImageLocation = alumno.FotoAlumno;
            this.txtApellido.Text = alumno.Apellido;
            this.txtDNI.Text = alumno.DNI.ToString();
            this.txtFoto.ReadOnly = true;
            this.txtNombre.Text = alumno.Nombre;
        }
    }
}
