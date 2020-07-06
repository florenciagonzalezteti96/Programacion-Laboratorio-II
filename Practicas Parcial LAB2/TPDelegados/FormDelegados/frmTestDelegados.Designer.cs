namespace FormDelegados
{
    partial class frmTestDelegados
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtFrmTestDelegados = new System.Windows.Forms.TextBox();
            this.ofdFrmTest = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(62, 68);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtFrmTestDelegados
            // 
            this.txtFrmTestDelegados.Location = new System.Drawing.Point(62, 42);
            this.txtFrmTestDelegados.Name = "txtFrmTestDelegados";
            this.txtFrmTestDelegados.Size = new System.Drawing.Size(116, 20);
            this.txtFrmTestDelegados.TabIndex = 1;
            // 
            // ofdFrmTest
            // 
            this.ofdFrmTest.FileName = "openFileDialog1";
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(62, 110);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(116, 36);
            this.btnBuscarFoto.TabIndex = 2;
            this.btnBuscarFoto.Text = "Buscar Foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // frmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 170);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.txtFrmTestDelegados);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmTestDelegados";
            this.Text = "frmTestDelegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtFrmTestDelegados;
        private System.Windows.Forms.OpenFileDialog ofdFrmTest;
        private System.Windows.Forms.Button btnBuscarFoto;
    }
}