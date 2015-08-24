using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalendarioAdmin.GUI
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_NuevoEvento frmNuevoEvento = new Frm_NuevoEvento();
            this.Hide();
            frmNuevoEvento.ShowDialog();
            this.Show();
        }

        private void btn_Modficar_Click(object sender, EventArgs e)
        {
            Frm_ModificarEvento frmModificarEvento = new Frm_ModificarEvento();
            this.Hide();
            frmModificarEvento.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new Frm_Usuarios().ShowDialog();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Entity.CalendarioEntities Contexto = new Entity.CalendarioEntities(Modelos.UsuarioSistema.getConnectonString());
            Entity.usuarios usuario = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == Modelos.UsuarioSistema.IdUsuario);

            if (usuario.id_tipousuario == "S")
                btnUsuarios.Enabled = true;
            else
                btnUsuarios.Enabled = false;

        }

        private void btnActivacion_Click(object sender, EventArgs e)
        {
            new Frm_ActivarDesactivarEventos().ShowDialog();
        }
    }
}
