using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using EntidadeBaseDeDatos_Provincia;

namespace Persona
{
    public partial class DataAdapterProvincias : Form
    {
        private const String PATH_XML_PERSONAS = @"C:\archivos\DataTablePersonasDatos.xml";
        private const String PATH_XML_PERSONAS_SCHEMA = @"C:\archivos\DataTablePersonasSchema.xml";

        protected SqlDataAdapter da;

        protected DataTable dt;

        public DataAdapterProvincias()
        {
            InitializeComponent();

            if(!this.ConfigurarDataAdapter())
            {
                MessageBox.Show("Error al realizar la configuracion del DataAdapter");
                this.Close();
            }

            this.ConfigurarDataTable();

            try
            {
                this.da.Fill(this.dt); //de aca saca la informacion del DT. carga un DT con la info que obtiene del select command que tengo configurado para el DA
                                        //esta asociado al Select Command directamente. Ademas, abre el DT, lo carga, lo llena, se desconecta con la BD y libera recursos
                
                this.ConfigurarGrilla();

                this.dvgDataAdapter.DataSource = this.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConexcionDAProvincias);

                this.da = new SqlDataAdapter();

                //hago las 4 instrucciones
                this.da.SelectCommand = new SqlCommand("SELECT id, nombre_provincia, cantidad_habitantes FROM DatosProvincias", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO DatosProvincias (nombre_provincia, cantidad_habitantes) VALUES (@nombre_provincia, @cantidad_habitantes)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE PERSONAS SET nombre_provincia=@nombre_provincia, cantidad_habitantes=@cantidad_habitantes WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM PERSONAS WHERE id=@id", cn);

                //especifico parametros dependiendo de la instruccion y los parametros que usa
                this.da.InsertCommand.Parameters.Add("@nombre_provincia", SqlDbType.VarChar, 50, "nombre_provincia");//el primero es el nombre del parametro de la instruccion
                                                                                                                     //el segundo es el tipo de dato que esta definido en la BD
                                                                                                                     //el tercero es la longitud del dato que esta definido en la BD
                                                                                                                     //el ultimo es el nombre de la columna que lo toma del DT que esta 
                                                                                                                     //asociado al DA
                this.da.InsertCommand.Parameters.Add("@cantidad_habitantes", SqlDbType.Int, 4, "cantidad_habitantes");

                this.da.UpdateCommand.Parameters.Add("@nombre_provincia", SqlDbType.VarChar, 50, "nombre_provincia");
                this.da.UpdateCommand.Parameters.Add("@cantidad_habitantes", SqlDbType.Int, 4, "cantidad_habitantes");
                this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");

                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id"); //cambio 10 por 4

                rta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Provincia");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre_provincia", typeof(string));
            this.dt.Columns.Add("cantidad_habitantes", typeof(int));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dt.Columns["id"].AutoIncrementStep = 1;
        }

        private void ConfigurarGrilla()
        {
            this.dvgDataAdapter.RowsDefaultCellStyle.BackColor = Color.Beige;

            this.dvgDataAdapter.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dvgDataAdapter.ColumnHeadersDefaultCellStyle.BackColor = Color.AntiqueWhite;

            this.dvgDataAdapter.ReadOnly = false;

            this.dvgDataAdapter.MultiSelect = false;

            this.dvgDataAdapter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dvgDataAdapter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dvgDataAdapter.RowsDefaultCellStyle.SelectionBackColor = Color.Coral;

            this.dvgDataAdapter.EditMode = DataGridViewEditMode.EditProgrammatically; //tengo que codear la edicion

            this.dvgDataAdapter.RowHeadersVisible = false;
        }

        private void btnCargarDT_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(PATH_XML_PERSONAS_SCHEMA))
                {
                    this.dt = new DataTable();

                    this.dt.ReadXmlSchema(PATH_XML_PERSONAS_SCHEMA);

                    MessageBox.Show("Se ha cargado el esquema del DataTable");
                }
                else
                {
                    MessageBox.Show("No existe ningún documento XML");
                }


                if (File.Exists(PATH_XML_PERSONAS))
                {
                    this.dt.ReadXml(PATH_XML_PERSONAS);

                    MessageBox.Show("Se han cargado los datos del DataTable");

                }
                else
                {
                    MessageBox.Show("No existe ningún documento XML");
                }

                this.dvgDataAdapter.DataSource = this.dt;
            }
            catch
            {
                MessageBox.Show("Error al cargar el DataTable. ","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardarDT_Click(object sender, EventArgs e)
        {
            try
            {
                this.dt.WriteXmlSchema(PATH_XML_PERSONAS_SCHEMA);

                this.dt.WriteXml(PATH_XML_PERSONAS);

                MessageBox.Show("Se han guardado el esquema y los datos del DataTable!!!");

            }
            catch
            {
                MessageBox.Show("Error al guardar el DataTable. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                this.da.Update(this.dt); //si es unchanged, no hace nada, pero si no ejecuta el comando que sea, para update, delete, etc

                MessageBox.Show("Sincronizado!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormProvincia frm = new FormProvincia();
            frm.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow fila = this.dt.NewRow();

                    fila["nombre_provincia"] = frm.ProvinciaIngresada.NombreProvincia;
                    fila["cantidad_habitantes"] = frm.ProvinciaIngresada.CantidadHabitantes;

                    this.dt.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int i = this.dvgDataAdapter.CurrentRow.Index;

            DataRow filaModificada = this.dt.Rows[i];

            Provincia provincia = new Provincia(int.Parse(filaModificada["id"].ToString()),
                                    filaModificada["nombre_provincia"].ToString(),
                                    int.Parse(filaModificada["cantidad_habitantes"].ToString()));

            FormProvincia frmProvincia = new FormProvincia(provincia);

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                filaModificada["nombre_provincia"] = frmProvincia.ProvinciaIngresada.NombreProvincia;
                filaModificada["cantidad_habitantes"] = frmProvincia.ProvinciaIngresada.CantidadHabitantes;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.dvgDataAdapter.CurrentRow.Index;

            DataRow filaEliminada = this.dt.Rows[i];

            Provincia provincia = new Provincia(int.Parse(filaEliminada["id"].ToString()),
                                    filaEliminada["nombre_provincia"].ToString(),
                                    int.Parse(filaEliminada["cantidad_habitantes"].ToString()));

            FormProvincia frmProvincia = new FormProvincia(provincia);

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                filaEliminada.Delete(); //es un borrado logico, la fila sigue existiendo hasta que acepto los cambios
            }
        }
    }
}
