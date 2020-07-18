namespace SistemaDeComercio
{
    partial class SistemaComercioFrm
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPerdidas = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Linen;
            this.btnStock.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnStock.Location = new System.Drawing.Point(99, 23);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(140, 80);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "STOCK";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Linen;
            this.btnClientes.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnClientes.Location = new System.Drawing.Point(286, 23);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(140, 80);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Linen;
            this.btnVentas.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnVentas.Location = new System.Drawing.Point(12, 130);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(140, 80);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnPerdidas
            // 
            this.btnPerdidas.BackColor = System.Drawing.Color.Linen;
            this.btnPerdidas.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnPerdidas.Location = new System.Drawing.Point(198, 130);
            this.btnPerdidas.Name = "btnPerdidas";
            this.btnPerdidas.Size = new System.Drawing.Size(140, 80);
            this.btnPerdidas.TabIndex = 3;
            this.btnPerdidas.Text = "REGISTRAR PERDIDAS";
            this.btnPerdidas.UseVisualStyleBackColor = false;
            // 
            // btnCierre
            // 
            this.btnCierre.BackColor = System.Drawing.Color.Linen;
            this.btnCierre.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCierre.Location = new System.Drawing.Point(378, 130);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(140, 80);
            this.btnCierre.TabIndex = 4;
            this.btnCierre.Text = "CIERRE DEL MES";
            this.btnCierre.UseVisualStyleBackColor = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblRegistro.Location = new System.Drawing.Point(462, 233);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(78, 16);
            this.lblRegistro.TabIndex = 5;
            this.lblRegistro.Text = "F. Gonzalez";
            // 
            // SistemaComercioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(540, 254);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnPerdidas);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnStock);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SistemaComercioFrm";
            this.Text = "Sistema de Administracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnPerdidas;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label lblRegistro;
    }
}

