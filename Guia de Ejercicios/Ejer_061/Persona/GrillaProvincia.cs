using EntidadeBaseDeDatos_Provincia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class GrillaProvincia : Form
    {
        AccesoDatos_Provincia accesoADatos;
        List<Provincia> provincias;
       public  DataTable tablaProvincias;


        public GrillaProvincia()
        {
            InitializeComponent();

            this.accesoADatos = new AccesoDatos_Provincia(); //configuro el acceso a la base
            this.provincias = this.accesoADatos.ObtenerListaProvincias();
            this.tablaProvincias = this.accesoADatos.ObtenerDataTableProvincias();
        }

        private void GrillaProvincia_Load(object sender, EventArgs e)
        {
            this.ConfigurarGrilla();
            //this.dgvProvincias.DataSource = this.provincias;
            this.dgvProvincias.DataSource = this.tablaProvincias;
        }

        private void ConfigurarGrilla()
        {
            this.dgvProvincias.RowsDefaultCellStyle.BackColor = Color.Beige;

            this.dgvProvincias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProvincias.ColumnHeadersDefaultCellStyle.BackColor = Color.AntiqueWhite;

            this.dgvProvincias.ReadOnly = false;

            this.dgvProvincias.MultiSelect = false;

            this.dgvProvincias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dgvProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvProvincias.RowsDefaultCellStyle.SelectionBackColor = Color.Coral;

            this.dgvProvincias.EditMode = DataGridViewEditMode.EditProgrammatically; //tengo que codear la edicion

            this.dgvProvincias.RowHeadersVisible = false;
        }

        private void GrillaProvincia_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormProvincia frmProvincia = new FormProvincia();

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                if (!this.accesoADatos.AgregarProvinciaABase(frmProvincia.ProvinciaIngresada))
                {
                    MessageBox.Show("Error al ingresar la nueva provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //genero nueva fila! Las tablas se componen de una coleccion de filas y cada una tiene una coleccion de columnas
            DataRow fila = this.tablaProvincias.NewRow(); //me genera una nueva fila, respetando las columnas de la base de datos
            fila["nombre_provincia"] = frmProvincia.ProvinciaIngresada.NombreProvincia;
            fila["cantidad_habitantes"] = frmProvincia.ProvinciaIngresada.CantidadHabitantes;

            this.tablaProvincias.Rows.Add(fila);
            this.tablaProvincias.AcceptChanges();

            /*this.provincias = this.accesoADatos.ObtenerListaProvincias();
            this.dgvProvincias.DataSource = this.provincias;*/

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.dgvProvincias.SelectedRows[0].Index;
            Provincia provincia = this.provincias[i];

            if (!this.accesoADatos.EliminarProvincia(provincia.ID))
            {
                MessageBox.Show("Error al eliminar la provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.tablaProvincias.Rows[i].Delete();
            this.tablaProvincias.AcceptChanges();

            /*this.provincias = this.accesoADatos.ObtenerListaProvincias();
            this.dgvProvincias.DataSource = this.provincias;*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int i = this.dgvProvincias.SelectedRows[0].Index;
            Provincia provincia = this.provincias[i];

            FormProvincia frmProvincia = new FormProvincia(provincia);

            frmProvincia.StartPosition = FormStartPosition.CenterScreen;

            if (frmProvincia.ShowDialog() == DialogResult.OK)
            {
                if (!this.accesoADatos.ModificarProvincia(frmProvincia.ProvinciaIngresada))
                {
                    MessageBox.Show("Error al modificar la provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.tablaProvincias.Rows[i]["nombre_provincia"] = frmProvincia.ProvinciaIngresada.NombreProvincia;
            this.tablaProvincias.Rows[i]["cantidad_habitantes"] = frmProvincia.ProvinciaIngresada.CantidadHabitantes;
            this.tablaProvincias.AcceptChanges();

            /*this.provincias = this.accesoADatos.ObtenerListaProvincias();
            this.dgvProvincias.DataSource = this.provincias;*/
        }
    }
}
