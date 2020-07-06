namespace MiLavadero
{
    partial class FormVehiculo
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblCantRuedas = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtCantRuedas = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptarVehiculo = new System.Windows.Forms.Button();
            this.btnCancelarVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(40, 29);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente:";
            // 
            // lblCantRuedas
            // 
            this.lblCantRuedas.AutoSize = true;
            this.lblCantRuedas.Location = new System.Drawing.Point(40, 71);
            this.lblCantRuedas.Name = "lblCantRuedas";
            this.lblCantRuedas.Size = new System.Drawing.Size(102, 13);
            this.lblCantRuedas.TabIndex = 1;
            this.lblCantRuedas.Text = "Cantidad de ruedas:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(40, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(43, 45);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 3;
            // 
            // txtCantRuedas
            // 
            this.txtCantRuedas.Location = new System.Drawing.Point(43, 87);
            this.txtCantRuedas.Name = "txtCantRuedas";
            this.txtCantRuedas.Size = new System.Drawing.Size(100, 20);
            this.txtCantRuedas.TabIndex = 4;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(43, 131);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // btnAceptarVehiculo
            // 
            this.btnAceptarVehiculo.Location = new System.Drawing.Point(12, 211);
            this.btnAceptarVehiculo.Name = "btnAceptarVehiculo";
            this.btnAceptarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarVehiculo.TabIndex = 6;
            this.btnAceptarVehiculo.Text = "Aceptar";
            this.btnAceptarVehiculo.UseVisualStyleBackColor = true;
            this.btnAceptarVehiculo.Click += new System.EventHandler(this.btnAceptarVehiculo_Click);
            // 
            // btnCancelarVehiculo
            // 
            this.btnCancelarVehiculo.Location = new System.Drawing.Point(126, 211);
            this.btnCancelarVehiculo.Name = "btnCancelarVehiculo";
            this.btnCancelarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVehiculo.TabIndex = 7;
            this.btnCancelarVehiculo.Text = "Cancelar";
            this.btnCancelarVehiculo.UseVisualStyleBackColor = true;
            this.btnCancelarVehiculo.Click += new System.EventHandler(this.btnCancelarVehiculo_Click);
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 249);
            this.Controls.Add(this.btnCancelarVehiculo);
            this.Controls.Add(this.btnAceptarVehiculo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtCantRuedas);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCantRuedas);
            this.Controls.Add(this.lblPatente);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblPatente;
        protected System.Windows.Forms.Label lblCantRuedas;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.TextBox txtPatente;
        protected System.Windows.Forms.TextBox txtCantRuedas;
        protected System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnAceptarVehiculo;
        private System.Windows.Forms.Button btnCancelarVehiculo;
    }
}