using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadeBaseDeDatos_Provincia;

namespace Persona
{
    public partial class DataTableProvincias : Form
    {
        private const String PATH_XML_PERSONAS = "DataTablePersonasDatos.xml";
        private const String PATH_XML_PERSONAS_SCHEMA = "DataTablePersonasSchema.xml";

        private DataTable dtProvincia;

        public DataTableProvincias()
        {
            InitializeComponent();
        }

        private void btnCrearDT_Click(object sender, EventArgs e)
        {
            this.dtProvincia = new DataTable("Provincia");

            this.dtProvincia.Columns.Add("id", typeof(int));
            this.dtProvincia.Columns.Add("nombre_provincia", typeof(string));
            this.dtProvincia.Columns.Add("cantidad_habitantes", typeof(int));

            this.dtProvincia.PrimaryKey = new DataColumn[] { this.dtProvincia.Columns[0] };

            this.dtProvincia.Columns["id"].AutoIncrement = true;
            this.dtProvincia.Columns["id"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dtProvincia.Columns["id"].AutoIncrementStep = 1;

            MessageBox.Show("Se creo el Data Table");

            this.dgvDTProvincia.DataSource = this.dtProvincia;
        }

        private Boolean CargarDataTableConArrayObject()
        {
            Boolean todoOK = false;

            try
            {
                //this.dtPersona.Rows.Add(new Object[] {"Mario", "Martinez", 66 });
                this.dtProvincia.Rows.Add(new Object[] { 1, "Bangkok", 66 });
                this.dtProvincia.Rows.Add(new Object[] { 2, "P2", 66 });
                this.dtProvincia.Rows.Add(new Object[] { 3, "p3", 66 });
                this.dtProvincia.Rows.Add(new Object[] { 4, "p4", 66 });

                todoOK = true;
            }
            catch (Exception)
            {
                todoOK = false;
            }

            return todoOK;
        }
        private Boolean CargarDataTableConListaProvincias()
        {
            Boolean todoOK = false;
            AccesoDatos_Provincia acceso = new AccesoDatos_Provincia();

            try
            {
                DataRow fila;

                if(dtProvincia != null)
                {
                    foreach (Provincia p in acceso.ObtenerListaProvincias())
                    {
                        fila = this.dtProvincia.NewRow();

                        //fila[0] = p.ID;
                        fila["nombre_provincia"] = p.NombreProvincia;
                        fila["cantidad_habitantes"] = p.CantidadHabitantes;

                        this.dtProvincia.Rows.Add(fila);
                    }

                    todoOK = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                todoOK = false;
            }

            return todoOK;
        }
        private void btnCargarDTArray_Click(object sender, EventArgs e)
        {
            if(!this.CargarDataTableConArrayObject())
            {
                MessageBox.Show("Se ha producido un error al cargar el DT con un array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se cargo el DT con el array");

            }
        }

        private void btnCargarDTLista_Click(object sender, EventArgs e)
        {
            if (!this.CargarDataTableConListaProvincias())
            {
                MessageBox.Show("Se ha producido un error al cargar el DT con una lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se cargo el DT con la lista");

            }
        }

        private void btnSerializarEsquemaDT_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtProvincia.WriteXmlSchema(PATH_XML_PERSONAS_SCHEMA);
                MessageBox.Show("Se serializo el schema del DT con XML");
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error al serializar el schema del DT con XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSerializarDatosDT_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtProvincia.WriteXml(PATH_XML_PERSONAS);
                MessageBox.Show("Se serializo el DT con XML");
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error al serializar el DT con XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarEsquemaDT_Click(object sender, EventArgs e)
        {
            if(File.Exists(PATH_XML_PERSONAS_SCHEMA))
            {
                this.dtProvincia.ReadXmlSchema(PATH_XML_PERSONAS_SCHEMA);
                MessageBox.Show("Se cargo el schema del DT con XML");

                this.dgvDTProvincia.DataSource = this.dtProvincia;
            }
            else
            {
                MessageBox.Show("Se ha producido un error al cargar el schema del DT con XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarDatosDT_Click(object sender, EventArgs e)
        {
            if (File.Exists(PATH_XML_PERSONAS))
            {
                this.dtProvincia.ReadXml(PATH_XML_PERSONAS);
                MessageBox.Show("Se cargo el DT con XML");

                this.dgvDTProvincia.DataSource = this.dtProvincia;
            }
            else
            {
                MessageBox.Show("Se ha producido un error al cargar el DT con XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarRowState_Click(object sender, EventArgs e)
        {
            RowStateDTProvincias estadoFilas = new RowStateDTProvincias(this.dtProvincia);

            estadoFilas.StartPosition = FormStartPosition.CenterScreen;

            estadoFilas.ShowDialog();
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            dtProvincia.AcceptChanges();
        }

        private void btnDeshacerCambios_Click(object sender, EventArgs e)
        {
            dtProvincia.RejectChanges();
        }

        private void btnCargarDTForms_Click(object sender, EventArgs e)
        {
            FormProvincia frm = new FormProvincia();

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow fila = this.dtProvincia.NewRow();

                    fila["nombre_provincia"] = frm.ProvinciaIngresada.NombreProvincia;
                    fila["cantidad_habitantes"] = frm.ProvinciaIngresada.CantidadHabitantes;

                    this.dtProvincia.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarListas_Click(object sender, EventArgs e)
        {
            int i = this.dgvDTProvincia.CurrentRow.Index;
            Provincia provincia = new Provincia(int.Parse(this.dtProvincia.Rows[i][0].ToString()),
                                    this.dtProvincia.Rows[i]["nombre_provincia"].ToString(), 
                                    int.Parse(this.dtProvincia.Rows[i]["cantidad_habitantes"].ToString()));

            FormProvincia frmProvincia = new FormProvincia(provincia);

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                this.dtProvincia.Rows[i]["nombre_provincia"] = frmProvincia.ProvinciaIngresada.NombreProvincia;
                this.dtProvincia.Rows[i]["cantidad_habitantes"] = frmProvincia.ProvinciaIngresada.CantidadHabitantes;
            }  
        }

        private void btnBorrarFilas_Click(object sender, EventArgs e)
        {
            int i = this.dgvDTProvincia.CurrentRow.Index;
            Provincia provincia = new Provincia(int.Parse(this.dtProvincia.Rows[i][0].ToString()),
                                    this.dtProvincia.Rows[i]["nombre_provincia"].ToString(),
                                    int.Parse(this.dtProvincia.Rows[i]["cantidad_habitantes"].ToString()));

            FormProvincia frmProvincia = new FormProvincia(provincia);

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                this.dtProvincia.Rows[i].Delete(); //es un borrado logico, la fila sigue existiendo hasta que acepto los cambios
            }
        }
    }
}
