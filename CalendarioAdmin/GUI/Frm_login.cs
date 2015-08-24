using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalendarioAdmin.Entity;
using CalendarioAdmin.Modelos;

namespace CalendarioAdmin.GUI
{
    public partial class Frm_login : Form
    {
        private CalendarioEntities Context;

        public Frm_login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string sUser = txbUser.Text.ToUpper();
            string sPass = txbPass.Text.ToUpper();

            try
            {
                Logger.AgregarLog(string.Format("Validando usuario {0}.....", sUser));

                ValidarUsuario(sUser, sPass);
            }
            catch (Exception ex)
            {
                var excep = ex;
                StringBuilder Mensaje = new StringBuilder();
                while (excep != null)
                {
                    Mensaje.AppendLine(excep.Message + Environment.NewLine);
                    excep = excep.InnerException;
                }

                Logger.AgregarLog(ex.ToString());

                MessageBox.Show("Error de inicio de sesión, revise la configuración del servidor..."+
                                 Mensaje.ToString(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarUsuario(string user, string pass)
        {
            Logger.AgregarLog("Crear contexto...");
            Context = new CalendarioEntities(UsuarioSistema.getConnectonString());

            Logger.AgregarLog("Consultar usuario...");
            usuarios dbuser = 
                Context.usuarios.FirstOrDefault(o => o.nombre.ToUpper() == user 
                                                  && o.contraseña.ToUpper() == pass);

            if (dbuser == null)
            {
                Logger.AgregarLog("El usuario no se encontró...");
                MessageBox.Show("Error de inicio de sesión");
            }
            else
            {
                Logger.AgregarLog("Usuario valido, iniciando aplicación...");

                UsuarioSistema.IdUsuario = dbuser.id_usuario;
                UsuarioSistema.sNombreSusuario = dbuser.nombre;

                Frm_Menu frmMenu = new Frm_Menu();
                this.Hide();
                frmMenu.ShowDialog();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Logger.AgregarLog("Cerrando aplicación...");
            this.Close();
        }

        private void txbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sUser = txbUser.Text.ToUpper();
                string sPass = txbPass.Text.ToUpper();

                ValidarUsuario(sUser, sPass);
            }
        }
        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sUser = txbUser.Text.ToUpper();
                string sPass = txbPass.Text.ToUpper();

                ValidarUsuario(sUser, sPass);
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Logger.AgregarLog("Abrir formulario de configuración...");
            new Frm_Configurar().ShowDialog();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
