namespace Persona
{
    partial class FormProvincia
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
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.lblNombreProvincia = new System.Windows.Forms.Label();
            this.lblCantidadHabitantes = new System.Windows.Forms.Label();
            this.txtCantidadHabitantes = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.txtNombreProvincia.Location = new System.Drawing.Point(38, 40);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(183, 20);
            this.txtNombreProvincia.TabIndex = 0;
            // 
            // lblNombreProvincia
            // 
            this.lblNombreProvincia.AutoSize = true;
            this.lblNombreProvincia.Location = new System.Drawing.Point(35, 24);
            this.lblNombreProvincia.Name = "lblNombreProvincia";
            this.lblNombreProvincia.Size = new System.Drawing.Size(117, 13);
            this.lblNombreProvincia.TabIndex = 1;
            this.lblNombreProvincia.Text = "Nombre de la Provincia";
            // 
            // lblCantidadHabitantes
            // 
            this.lblCantidadHabitantes.AutoSize = true;
            this.lblCantidadHabitantes.Location = new System.Drawing.Point(35, 82);
            this.lblCantidadHabitantes.Name = "lblCantidadHabitantes";
            this.lblCantidadHabitantes.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadHabitantes.TabIndex = 2;
            this.lblCantidadHabitantes.Text = "Cantidad de Habitantes";
            // 
            // txtCantidadHabitantes
            // 
            this.txtCantidadHabitantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.txtCantidadHabitantes.Location = new System.Drawing.Point(38, 98);
            this.txtCantidadHabitantes.Name = "txtCantidadHabitantes";
            this.txtCantidadHabitantes.Size = new System.Drawing.Size(183, 20);
            this.txtCantidadHabitantes.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 38);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(274, 182);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadHabitantes);
            this.Controls.Add(this.lblCantidadHabitantes);
            this.Controls.Add(this.lblNombreProvincia);
            this.Controls.Add(this.txtNombreProvincia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProvincia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label lblNombreProvincia;
        private System.Windows.Forms.Label lblCantidadHabitantes;
        private System.Windows.Forms.TextBox txtCantidadHabitantes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

