using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class RowStateDTProvincias : Form
    {
        public RowStateDTProvincias(DataTable DTProvincias)
        {
            InitializeComponent();

            this.dgvFilasDTProvincias.Columns.Add("estado", "Estado de Fila");

            foreach (DataRow fila in DTProvincias.Rows)
            {
                this.dgvFilasDTProvincias.Rows.Add(fila.RowState.ToString());
            }
        }
    }
}
