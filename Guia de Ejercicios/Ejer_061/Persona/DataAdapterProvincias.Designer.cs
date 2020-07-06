namespace Persona
{
    partial class DataAdapterProvincias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgDataAdapter = new System.Windows.Forms.DataGridView();
            this.btnCargarDT = new System.Windows.Forms.Button();
            this.btnGuardarDT = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataAdapter)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDataAdapter
            // 
            this.dvgDataAdapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDataAdapter.Location = new System.Drawing.Point(12, 12);
            this.dvgDataAdapter.Name = "dvgDataAdapter";
            this.dvgDataAdapter.Size = new System.Drawing.Size(436, 235);
            this.dvgDataAdapter.TabIndex = 0;
            // 
            // btnCargarDT
            // 
            this.btnCargarDT.Location = new System.Drawing.Point(90, 265);
            this.btnCargarDT.Name = "btnCargarDT";
            this.btnCargarDT.Size = new System.Drawing.Size(118, 23);
            this.btnCargarDT.TabIndex = 1;
            this.btnCargarDT.Text = "Cargar Data Table";
            this.btnCargarDT.UseVisualStyleBackColor = true;
            this.btnCargarDT.Click += new System.EventHandler(this.btnCargarDT_Click);
            // 
            // btnGuardarDT
            // 
            this.btnGuardarDT.Location = new System.Drawing.Point(225, 265);
            this.btnGuardarDT.Name = "btnGuardarDT";
            this.btnGuardarDT.Size = new System.Drawing.Size(118, 23);
            this.btnGuardarDT.TabIndex = 2;
            this.btnGuardarDT.Text = "Guardar Data Table";
            this.btnGuardarDT.UseVisualStyleBackColor = true;
            this.btnGuardarDT.Click += new System.EventHandler(this.btnGuardarDT_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(133, 311);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(225, 311);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(36, 311);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(75, 23);
            this.btnGuarda.TabIndex = 6;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // DataAdapterProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 362);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnGuardarDT);
            this.Controls.Add(this.btnCargarDT);
            this.Controls.Add(this.dvgDataAdapter);
            this.Name = "DataAdapterProvincias";
            this.Text = "DataAdapterProvincias";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataAdapter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDataAdapter;
        private System.Windows.Forms.Button btnCargarDT;
        private System.Windows.Forms.Button btnGuardarDT;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuarda;
    }
}