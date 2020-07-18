namespace SistemaDeComercio
{
    partial class StockFrm
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
            this.lblStock = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.rbCodigoProducto = new System.Windows.Forms.RadioButton();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.rbNombreProducto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(54, 18);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(58, 22);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.BackColor = System.Drawing.Color.Linen;
            this.btnCargarProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarProducto.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCargarProducto.Location = new System.Drawing.Point(30, 63);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(106, 61);
            this.btnCargarProducto.TabIndex = 1;
            this.btnCargarProducto.Text = "Agregar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // rbCodigoProducto
            // 
            this.rbCodigoProducto.AutoSize = true;
            this.rbCodigoProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoProducto.Location = new System.Drawing.Point(9, 130);
            this.rbCodigoProducto.Name = "rbCodigoProducto";
            this.rbCodigoProducto.Size = new System.Drawing.Size(180, 24);
            this.rbCodigoProducto.TabIndex = 2;
            this.rbCodigoProducto.TabStop = true;
            this.rbCodigoProducto.Text = "cargar producto con codigo";
            this.rbCodigoProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.Linen;
            this.btnModificarProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnModificarProducto.Location = new System.Drawing.Point(30, 198);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(106, 61);
            this.btnModificarProducto.TabIndex = 3;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // lbStock
            // 
            this.lbStock.BackColor = System.Drawing.Color.Linen;
            this.lbStock.FormattingEnabled = true;
            this.lbStock.Location = new System.Drawing.Point(200, 8);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(517, 290);
            this.lbStock.TabIndex = 4;
            // 
            // rbNombreProducto
            // 
            this.rbNombreProducto.AutoSize = true;
            this.rbNombreProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombreProducto.Location = new System.Drawing.Point(9, 156);
            this.rbNombreProducto.Name = "rbNombreProducto";
            this.rbNombreProducto.Size = new System.Drawing.Size(185, 24);
            this.rbNombreProducto.TabIndex = 5;
            this.rbNombreProducto.TabStop = true;
            this.rbNombreProducto.Text = "cargar producto con nombre";
            this.rbNombreProducto.UseVisualStyleBackColor = true;
            // 
            // StockFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(729, 310);
            this.Controls.Add(this.rbNombreProducto);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.rbCodigoProducto);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.lblStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.RadioButton rbCodigoProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.RadioButton rbNombreProducto;
    }
}