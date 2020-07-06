namespace Persona
{
    partial class RowStateDTProvincias
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
            this.dgvFilasDTProvincias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilasDTProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilasDTProvincias
            // 
            this.dgvFilasDTProvincias.AllowUserToOrderColumns = true;
            this.dgvFilasDTProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilasDTProvincias.Location = new System.Drawing.Point(12, 12);
            this.dgvFilasDTProvincias.Name = "dgvFilasDTProvincias";
            this.dgvFilasDTProvincias.Size = new System.Drawing.Size(297, 426);
            this.dgvFilasDTProvincias.TabIndex = 0;
            // 
            // RowStateDTProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.dgvFilasDTProvincias);
            this.Name = "RowStateDTProvincias";
            this.Text = "RowStateDTProvincias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilasDTProvincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilasDTProvincias;
    }
}