namespace MiLavadero
{
    partial class FormAuto
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
            this.lblCantAsientos = new System.Windows.Forms.Label();
            this.txtCantAsientos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCantAsientos
            // 
            this.lblCantAsientos.AutoSize = true;
            this.lblCantAsientos.Location = new System.Drawing.Point(40, 164);
            this.lblCantAsientos.Name = "lblCantAsientos";
            this.lblCantAsientos.Size = new System.Drawing.Size(109, 13);
            this.lblCantAsientos.TabIndex = 8;
            this.lblCantAsientos.Text = "Cantidad de asientos:";
            // 
            // txtCantAsientos
            // 
            this.txtCantAsientos.Location = new System.Drawing.Point(42, 180);
            this.txtCantAsientos.Name = "txtCantAsientos";
            this.txtCantAsientos.Size = new System.Drawing.Size(100, 20);
            this.txtCantAsientos.TabIndex = 9;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 239);
            this.Controls.Add(this.txtCantAsientos);
            this.Controls.Add(this.lblCantAsientos);
            this.Name = "FormAuto";
            this.Text = "FormAuto";
            this.Controls.SetChildIndex(this.lblCantAsientos, 0);
            this.Controls.SetChildIndex(this.txtCantAsientos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantAsientos;
        private System.Windows.Forms.TextBox txtCantAsientos;
    }
}