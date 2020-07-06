namespace MiLavadero
{
    partial class FormCamion
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
            this.lblTara = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Location = new System.Drawing.Point(40, 164);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(29, 13);
            this.lblTara.TabIndex = 8;
            this.lblTara.Text = "Tara";
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(43, 180);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 20);
            this.txtTara.TabIndex = 9;
            // 
            // FormCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 243);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.lblTara);
            this.Name = "FormCamion";
            this.Text = "FormCamion";
            this.Controls.SetChildIndex(this.lblTara, 0);
            this.Controls.SetChildIndex(this.txtTara, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.TextBox txtTara;
    }
}