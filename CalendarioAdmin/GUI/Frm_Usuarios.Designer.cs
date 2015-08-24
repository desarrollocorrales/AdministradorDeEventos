namespace CalendarioAdmin.GUI
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.tabsUsuarios = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txbContraseña2 = new System.Windows.Forms.TextBox();
            this.txbContraseña1 = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.cbNombreUsuario = new System.Windows.Forms.ComboBox();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbTipoUsuarioMod = new System.Windows.Forms.ComboBox();
            this.txbContraseñaMod2 = new System.Windows.Forms.TextBox();
            this.txbContraseñaMod1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.btnCancelarEliminar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbUsuarioEliminar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabsUsuarios.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsUsuarios
            // 
            this.tabsUsuarios.Controls.Add(this.tabNuevo);
            this.tabsUsuarios.Controls.Add(this.tabModificar);
            this.tabsUsuarios.Controls.Add(this.tabEliminar);
            this.tabsUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsUsuarios.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsUsuarios.Location = new System.Drawing.Point(0, 35);
            this.tabsUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabsUsuarios.Name = "tabsUsuarios";
            this.tabsUsuarios.SelectedIndex = 0;
            this.tabsUsuarios.Size = new System.Drawing.Size(472, 238);
            this.tabsUsuarios.TabIndex = 0;
            this.tabsUsuarios.SelectedIndexChanged += new System.EventHandler(this.tabsUsuarios_SelectedIndexChanged);
            // 
            // tabNuevo
            // 
            this.tabNuevo.Controls.Add(this.btnCancelar);
            this.tabNuevo.Controls.Add(this.btnAgregar);
            this.tabNuevo.Controls.Add(this.cbTipoUsuario);
            this.tabNuevo.Controls.Add(this.txbContraseña2);
            this.tabNuevo.Controls.Add(this.txbContraseña1);
            this.tabNuevo.Controls.Add(this.txbNombre);
            this.tabNuevo.Controls.Add(this.label4);
            this.tabNuevo.Controls.Add(this.label3);
            this.tabNuevo.Controls.Add(this.label2);
            this.tabNuevo.Controls.Add(this.label1);
            this.tabNuevo.Location = new System.Drawing.Point(4, 25);
            this.tabNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNuevo.Size = new System.Drawing.Size(464, 209);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Agregar";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(154, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(185, 109);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(255, 24);
            this.cbTipoUsuario.TabIndex = 7;
            // 
            // txbContraseña2
            // 
            this.txbContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseña2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña2.Location = new System.Drawing.Point(185, 80);
            this.txbContraseña2.Name = "txbContraseña2";
            this.txbContraseña2.PasswordChar = '*';
            this.txbContraseña2.Size = new System.Drawing.Size(255, 23);
            this.txbContraseña2.TabIndex = 6;
            // 
            // txbContraseña1
            // 
            this.txbContraseña1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseña1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña1.Location = new System.Drawing.Point(185, 51);
            this.txbContraseña1.Name = "txbContraseña1";
            this.txbContraseña1.PasswordChar = '*';
            this.txbContraseña1.Size = new System.Drawing.Size(255, 23);
            this.txbContraseña1.TabIndex = 5;
            // 
            // txbNombre
            // 
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(185, 22);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(255, 23);
            this.txbNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.cbNombreUsuario);
            this.tabModificar.Controls.Add(this.btnCancelarMod);
            this.tabModificar.Controls.Add(this.btnModificar);
            this.tabModificar.Controls.Add(this.cbTipoUsuarioMod);
            this.tabModificar.Controls.Add(this.txbContraseñaMod2);
            this.tabModificar.Controls.Add(this.txbContraseñaMod1);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.label7);
            this.tabModificar.Controls.Add(this.label8);
            this.tabModificar.Location = new System.Drawing.Point(4, 25);
            this.tabModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabModificar.Size = new System.Drawing.Size(464, 209);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // cbNombreUsuario
            // 
            this.cbNombreUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreUsuario.FormattingEnabled = true;
            this.cbNombreUsuario.Location = new System.Drawing.Point(185, 21);
            this.cbNombreUsuario.Name = "cbNombreUsuario";
            this.cbNombreUsuario.Size = new System.Drawing.Size(255, 24);
            this.cbNombreUsuario.TabIndex = 18;
            this.cbNombreUsuario.SelectedIndexChanged += new System.EventHandler(this.cbNombreUsuario_SelectedIndexChanged);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(235, 164);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarMod.TabIndex = 17;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(154, 164);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 25);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbTipoUsuarioMod
            // 
            this.cbTipoUsuarioMod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuarioMod.FormattingEnabled = true;
            this.cbTipoUsuarioMod.Location = new System.Drawing.Point(185, 109);
            this.cbTipoUsuarioMod.Name = "cbTipoUsuarioMod";
            this.cbTipoUsuarioMod.Size = new System.Drawing.Size(255, 24);
            this.cbTipoUsuarioMod.TabIndex = 15;
            // 
            // txbContraseñaMod2
            // 
            this.txbContraseñaMod2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseñaMod2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseñaMod2.Location = new System.Drawing.Point(185, 80);
            this.txbContraseñaMod2.Name = "txbContraseñaMod2";
            this.txbContraseñaMod2.PasswordChar = '*';
            this.txbContraseñaMod2.Size = new System.Drawing.Size(255, 23);
            this.txbContraseñaMod2.TabIndex = 14;
            // 
            // txbContraseñaMod1
            // 
            this.txbContraseñaMod1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseñaMod1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseñaMod1.Location = new System.Drawing.Point(185, 51);
            this.txbContraseñaMod1.Name = "txbContraseñaMod1";
            this.txbContraseñaMod1.PasswordChar = '*';
            this.txbContraseñaMod1.Size = new System.Drawing.Size(255, 23);
            this.txbContraseñaMod1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre de Usuario:";
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.btnCancelarEliminar);
            this.tabEliminar.Controls.Add(this.btnEliminar);
            this.tabEliminar.Controls.Add(this.cbUsuarioEliminar);
            this.tabEliminar.Controls.Add(this.label9);
            this.tabEliminar.Location = new System.Drawing.Point(4, 25);
            this.tabEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEliminar.Size = new System.Drawing.Size(464, 209);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Location = new System.Drawing.Point(235, 164);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarEliminar.TabIndex = 22;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.UseVisualStyleBackColor = true;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(154, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbUsuarioEliminar
            // 
            this.cbUsuarioEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioEliminar.FormattingEnabled = true;
            this.cbUsuarioEliminar.Location = new System.Drawing.Point(175, 21);
            this.cbUsuarioEliminar.Name = "cbUsuarioEliminar";
            this.cbUsuarioEliminar.Size = new System.Drawing.Size(255, 24);
            this.cbUsuarioEliminar.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre de Usuario:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(472, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 273);
            this.Controls.Add(this.tabsUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.tabsUsuarios.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsUsuarios;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.TextBox txbContraseña2;
        private System.Windows.Forms.TextBox txbContraseña1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombreUsuario;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbTipoUsuarioMod;
        private System.Windows.Forms.TextBox txbContraseñaMod2;
        private System.Windows.Forms.TextBox txbContraseñaMod1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelarEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbUsuarioEliminar;
        private System.Windows.Forms.Label label9;
    }
}