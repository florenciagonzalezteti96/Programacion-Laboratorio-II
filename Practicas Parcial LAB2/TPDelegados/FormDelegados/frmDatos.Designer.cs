namespace FormDelegados
{
    partial class frmDatos
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
            this.lblFrmDatos = new System.Windows.Forms.Label();
            this.pbFrmDatos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrmDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrmDatos
            // 
            this.lblFrmDatos.AutoSize = true;
            this.lblFrmDatos.Location = new System.Drawing.Point(111, 160);
            this.lblFrmDatos.Name = "lblFrmDatos";
            this.lblFrmDatos.Size = new System.Drawing.Size(33, 13);
            this.lblFrmDatos.TabIndex = 0;
            this.lblFrmDatos.Text = "Label";
            // 
            // pbFrmDatos
            // 
            this.pbFrmDatos.Location = new System.Drawing.Point(67, 12);
            this.pbFrmDatos.Name = "pbFrmDatos";
            this.pbFrmDatos.Size = new System.Drawing.Size(127, 118);
            this.pbFrmDatos.TabIndex = 1;
            this.pbFrmDatos.TabStop = false;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 201);
            this.Controls.Add(this.pbFrmDatos);
            this.Controls.Add(this.lblFrmDatos);
            this.Name = "frmDatos";
            this.Text = "frmDatos";
            ((System.ComponentModel.ISupportInitialize)(this.pbFrmDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmDatos;
        private System.Windows.Forms.PictureBox pbFrmDatos;
    }
}