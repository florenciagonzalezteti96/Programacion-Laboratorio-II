namespace FormDelegados
{
    partial class FrmDatosAlumno
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
            this.pbDatosAlumno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatosAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDatosAlumno
            // 
            this.pbDatosAlumno.Location = new System.Drawing.Point(41, 202);
            this.pbDatosAlumno.Name = "pbDatosAlumno";
            this.pbDatosAlumno.Size = new System.Drawing.Size(210, 160);
            this.pbDatosAlumno.TabIndex = 10;
            this.pbDatosAlumno.TabStop = false;
            // 
            // FrmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 430);
            this.Controls.Add(this.pbDatosAlumno);
            this.Name = "FrmDatosAlumno";
            this.Text = "FrmDatosAlumno";
            this.Controls.SetChildIndex(this.pbDatosAlumno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbDatosAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDatosAlumno;
    }
}