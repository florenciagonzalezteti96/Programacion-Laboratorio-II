namespace MiLavadero
{
    partial class FormLavadero
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ListaVehiculos = new System.Windows.Forms.ListBox();
            this.lblNombreLavadero = new System.Windows.Forms.Label();
            this.BtnEliminarTodos = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnMostrarFacturado = new System.Windows.Forms.Button();
            this.RBtnAuto = new System.Windows.Forms.RadioButton();
            this.RBtnCamion = new System.Windows.Forms.RadioButton();
            this.RBtnMoto = new System.Windows.Forms.RadioButton();
            this.CmbOrdenar = new System.Windows.Forms.ComboBox();
            this.CmbFacturado = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnAgregar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnAgregar.Location = new System.Drawing.Point(12, 314);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 56);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "agregar vehiculo";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnEliminar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(138, 314);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 56);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "eliminar vehiculo";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ListaVehiculos
            // 
            this.ListaVehiculos.BackColor = System.Drawing.Color.MistyRose;
            this.ListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaVehiculos.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.ListaVehiculos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ListaVehiculos.FormattingEnabled = true;
            this.ListaVehiculos.HorizontalScrollbar = true;
            this.ListaVehiculos.Location = new System.Drawing.Point(12, 34);
            this.ListaVehiculos.Name = "ListaVehiculos";
            this.ListaVehiculos.Size = new System.Drawing.Size(532, 197);
            this.ListaVehiculos.TabIndex = 1;
            // 
            // lblNombreLavadero
            // 
            this.lblNombreLavadero.AutoSize = true;
            this.lblNombreLavadero.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLavadero.Location = new System.Drawing.Point(242, 9);
            this.lblNombreLavadero.Name = "lblNombreLavadero";
            this.lblNombreLavadero.Size = new System.Drawing.Size(71, 13);
            this.lblNombreLavadero.TabIndex = 0;
            this.lblNombreLavadero.Text = "LAVADERO";
            // 
            // BtnEliminarTodos
            // 
            this.BtnEliminarTodos.BackColor = System.Drawing.Color.MistyRose;
            this.BtnEliminarTodos.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnEliminarTodos.Location = new System.Drawing.Point(138, 237);
            this.BtnEliminarTodos.Name = "BtnEliminarTodos";
            this.BtnEliminarTodos.Size = new System.Drawing.Size(120, 71);
            this.BtnEliminarTodos.TabIndex = 6;
            this.BtnEliminarTodos.Text = "eliminar todos";
            this.BtnEliminarTodos.UseVisualStyleBackColor = false;
            this.BtnEliminarTodos.Click += new System.EventHandler(this.BtnEliminarTodos_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCerrar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnCerrar.Location = new System.Drawing.Point(399, 293);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(142, 77);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.Text = "cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMostrarFacturado
            // 
            this.BtnMostrarFacturado.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMostrarFacturado.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnMostrarFacturado.Location = new System.Drawing.Point(264, 321);
            this.BtnMostrarFacturado.Name = "BtnMostrarFacturado";
            this.BtnMostrarFacturado.Size = new System.Drawing.Size(126, 49);
            this.BtnMostrarFacturado.TabIndex = 10;
            this.BtnMostrarFacturado.Text = "mostrar total facturado";
            this.BtnMostrarFacturado.UseVisualStyleBackColor = false;
            this.BtnMostrarFacturado.Click += new System.EventHandler(this.BtnMostrarFacturado_Click);
            // 
            // RBtnAuto
            // 
            this.RBtnAuto.AutoSize = true;
            this.RBtnAuto.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.RBtnAuto.Location = new System.Drawing.Point(12, 237);
            this.RBtnAuto.Name = "RBtnAuto";
            this.RBtnAuto.Size = new System.Drawing.Size(57, 17);
            this.RBtnAuto.TabIndex = 2;
            this.RBtnAuto.TabStop = true;
            this.RBtnAuto.Text = "Auto";
            this.RBtnAuto.UseVisualStyleBackColor = true;
            // 
            // RBtnCamion
            // 
            this.RBtnCamion.AutoSize = true;
            this.RBtnCamion.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.RBtnCamion.Location = new System.Drawing.Point(12, 262);
            this.RBtnCamion.Name = "RBtnCamion";
            this.RBtnCamion.Size = new System.Drawing.Size(73, 17);
            this.RBtnCamion.TabIndex = 3;
            this.RBtnCamion.TabStop = true;
            this.RBtnCamion.Text = "Camion";
            this.RBtnCamion.UseVisualStyleBackColor = true;
            // 
            // RBtnMoto
            // 
            this.RBtnMoto.AutoSize = true;
            this.RBtnMoto.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.RBtnMoto.Location = new System.Drawing.Point(12, 285);
            this.RBtnMoto.Name = "RBtnMoto";
            this.RBtnMoto.Size = new System.Drawing.Size(57, 17);
            this.RBtnMoto.TabIndex = 4;
            this.RBtnMoto.TabStop = true;
            this.RBtnMoto.Text = "Moto";
            this.RBtnMoto.UseVisualStyleBackColor = true;
            // 
            // CmbOrdenar
            // 
            this.CmbOrdenar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.CmbOrdenar.FormattingEnabled = true;
            this.CmbOrdenar.Location = new System.Drawing.Point(399, 253);
            this.CmbOrdenar.Name = "CmbOrdenar";
            this.CmbOrdenar.Size = new System.Drawing.Size(142, 21);
            this.CmbOrdenar.TabIndex = 11;
            this.CmbOrdenar.TextChanged += new System.EventHandler(this.CmbOrdenar_TextChanged);
            // 
            // CmbFacturado
            // 
            this.CmbFacturado.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.CmbFacturado.FormattingEnabled = true;
            this.CmbFacturado.Location = new System.Drawing.Point(267, 293);
            this.CmbFacturado.Name = "CmbFacturado";
            this.CmbFacturado.Size = new System.Drawing.Size(117, 21);
            this.CmbFacturado.TabIndex = 9;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnModificar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(264, 237);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 50);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FormLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(553, 375);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.CmbFacturado);
            this.Controls.Add(this.CmbOrdenar);
            this.Controls.Add(this.RBtnMoto);
            this.Controls.Add(this.RBtnCamion);
            this.Controls.Add(this.RBtnAuto);
            this.Controls.Add(this.BtnMostrarFacturado);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminarTodos);
            this.Controls.Add(this.lblNombreLavadero);
            this.Controls.Add(this.ListaVehiculos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLavadero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Lavadero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLavadero_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ListBox ListaVehiculos;
        private System.Windows.Forms.Label lblNombreLavadero;
        private System.Windows.Forms.Button BtnEliminarTodos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMostrarFacturado;
        private System.Windows.Forms.RadioButton RBtnAuto;
        private System.Windows.Forms.RadioButton RBtnCamion;
        private System.Windows.Forms.RadioButton RBtnMoto;
        private System.Windows.Forms.ComboBox CmbOrdenar;
        private System.Windows.Forms.ComboBox CmbFacturado;
        private System.Windows.Forms.Button BtnModificar;
    }
}

