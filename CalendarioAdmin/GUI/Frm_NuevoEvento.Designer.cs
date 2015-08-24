namespace CalendarioAdmin.GUI
{
    partial class Frm_NuevoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoEvento));
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCuantaBancaria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNones = new System.Windows.Forms.RadioButton();
            this.rbPares = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudDiaEvento = new System.Windows.Forms.NumericUpDown();
            this.cbDiaSemana = new System.Windows.Forms.ComboBox();
            this.rbPorDia = new System.Windows.Forms.RadioButton();
            this.rbPorSemana = new System.Windows.Forms.RadioButton();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCantidad
            // 
            this.txbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCantidad.Location = new System.Drawing.Point(194, 206);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(306, 22);
            this.txbCantidad.TabIndex = 47;
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(428, 434);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 27);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNotas
            // 
            this.txbNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNotas.Location = new System.Drawing.Point(508, 224);
            this.txbNotas.Multiline = true;
            this.txbNotas.Name = "txbNotas";
            this.txbNotas.Size = new System.Drawing.Size(408, 186);
            this.txbNotas.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 14);
            this.label9.TabIndex = 43;
            this.label9.Text = "Notas (Opcional):";
            // 
            // txbCuantaBancaria
            // 
            this.txbCuantaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCuantaBancaria.Location = new System.Drawing.Point(194, 269);
            this.txbCuantaBancaria.Name = "txbCuantaBancaria";
            this.txbCuantaBancaria.Size = new System.Drawing.Size(306, 22);
            this.txbCuantaBancaria.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 14);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cuenta Bancaria (Opcional):";
            // 
            // txbBanco
            // 
            this.txbBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBanco.Location = new System.Drawing.Point(194, 238);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(306, 22);
            this.txbBanco.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 14);
            this.label7.TabIndex = 40;
            this.label7.Text = "Banco (Opcional):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cantidad a pagar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbNones);
            this.groupBox2.Controls.Add(this.rbPares);
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(506, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 145);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de repetición";
            // 
            // rbNones
            // 
            this.rbNones.AutoSize = true;
            this.rbNones.Location = new System.Drawing.Point(40, 92);
            this.rbNones.Name = "rbNones";
            this.rbNones.Size = new System.Drawing.Size(134, 18);
            this.rbNones.TabIndex = 14;
            this.rbNones.Text = "Solo meses nones";
            this.rbNones.UseVisualStyleBackColor = true;
            // 
            // rbPares
            // 
            this.rbPares.AutoSize = true;
            this.rbPares.Location = new System.Drawing.Point(40, 64);
            this.rbPares.Name = "rbPares";
            this.rbPares.Size = new System.Drawing.Size(130, 18);
            this.rbPares.TabIndex = 13;
            this.rbPares.Text = "Solo meses pares";
            this.rbPares.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(40, 36);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(124, 18);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los meses";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudDiaEvento);
            this.groupBox1.Controls.Add(this.cbDiaSemana);
            this.groupBox1.Controls.Add(this.rbPorDia);
            this.groupBox1.Controls.Add(this.rbPorSemana);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 110);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repetir";
            // 
            // nudDiaEvento
            // 
            this.nudDiaEvento.Location = new System.Drawing.Point(185, 29);
            this.nudDiaEvento.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDiaEvento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiaEvento.Name = "nudDiaEvento";
            this.nudDiaEvento.Size = new System.Drawing.Size(51, 22);
            this.nudDiaEvento.TabIndex = 18;
            this.nudDiaEvento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDiaSemana
            // 
            this.cbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaSemana.Enabled = false;
            this.cbDiaSemana.FormattingEnabled = true;
            this.cbDiaSemana.ItemHeight = 14;
            this.cbDiaSemana.Items.AddRange(new object[] {
            "- Seleccione un día -",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbDiaSemana.Location = new System.Drawing.Point(185, 59);
            this.cbDiaSemana.Name = "cbDiaSemana";
            this.cbDiaSemana.Size = new System.Drawing.Size(293, 22);
            this.cbDiaSemana.TabIndex = 21;
            // 
            // rbPorDia
            // 
            this.rbPorDia.AutoSize = true;
            this.rbPorDia.Checked = true;
            this.rbPorDia.Location = new System.Drawing.Point(7, 29);
            this.rbPorDia.Name = "rbPorDia";
            this.rbPorDia.Size = new System.Drawing.Size(118, 18);
            this.rbPorDia.TabIndex = 16;
            this.rbPorDia.TabStop = true;
            this.rbPorDia.Text = "Por dia del mes";
            this.rbPorDia.UseVisualStyleBackColor = true;
            this.rbPorDia.CheckedChanged += new System.EventHandler(this.rbPorDia_CheckedChanged);
            // 
            // rbPorSemana
            // 
            this.rbPorSemana.AutoSize = true;
            this.rbPorSemana.Location = new System.Drawing.Point(7, 60);
            this.rbPorSemana.Name = "rbPorSemana";
            this.rbPorSemana.Size = new System.Drawing.Size(151, 18);
            this.rbPorSemana.TabIndex = 20;
            this.rbPorSemana.Text = "Por dia de la semana";
            this.rbPorSemana.UseVisualStyleBackColor = true;
            this.rbPorSemana.CheckedChanged += new System.EventHandler(this.rbPorSemana_CheckedChanged);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescripcion.Location = new System.Drawing.Point(194, 86);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(306, 114);
            this.txbDescripcion.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion:";
            // 
            // txbNombre
            // 
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Location = new System.Drawing.Point(194, 54);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(306, 22);
            this.txbNombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre del evento:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(932, 40);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Nuevo Evento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_NuevoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbNotas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCuantaBancaria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbBanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_NuevoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Evento";
            this.Load += new System.EventHandler(this.Frm_NuevoEvento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCuantaBancaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNones;
        private System.Windows.Forms.RadioButton rbPares;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDiaEvento;
        private System.Windows.Forms.ComboBox cbDiaSemana;
        private System.Windows.Forms.RadioButton rbPorDia;
        private System.Windows.Forms.RadioButton rbPorSemana;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}