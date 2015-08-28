namespace CalendarioAdmin.GUI
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnActivacion = new System.Windows.Forms.Button();
            this.btn_Modficar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(682, 35);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Calendario de Pagos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.Image = global::CalendarioAdmin.Properties.Resources.Usuarios100px;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(510, 81);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(160, 150);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActivacion
            // 
            this.btnActivacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivacion.Image = global::CalendarioAdmin.Properties.Resources.check_list;
            this.btnActivacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActivacion.Location = new System.Drawing.Point(344, 81);
            this.btnActivacion.Name = "btnActivacion";
            this.btnActivacion.Size = new System.Drawing.Size(160, 150);
            this.btnActivacion.TabIndex = 2;
            this.btnActivacion.Text = "Activar / Desactivar Recordatorios";
            this.btnActivacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivacion.UseVisualStyleBackColor = true;
            this.btnActivacion.Click += new System.EventHandler(this.btnActivacion_Click);
            // 
            // btn_Modficar
            // 
            this.btn_Modficar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modficar.Image = global::CalendarioAdmin.Properties.Resources.ModifyEvent;
            this.btn_Modficar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Modficar.Location = new System.Drawing.Point(178, 81);
            this.btn_Modficar.Name = "btn_Modficar";
            this.btn_Modficar.Size = new System.Drawing.Size(160, 150);
            this.btn_Modficar.TabIndex = 1;
            this.btn_Modficar.Text = "Modificar un Recordatorio";
            this.btn_Modficar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Modficar.UseVisualStyleBackColor = true;
            this.btn_Modficar.Click += new System.EventHandler(this.btn_Modficar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.Image = global::CalendarioAdmin.Properties.Resources.NuevoEvento;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(12, 81);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 150);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Recordatorio";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 313);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActivacion);
            this.Controls.Add(this.btn_Modficar);
            this.Controls.Add(this.btnNuevo);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones programadas - Menú";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btn_Modficar;
        private System.Windows.Forms.Button btnActivacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnUsuarios;
    }
}