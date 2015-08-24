using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalendarioAdmin.Entity;

namespace CalendarioAdmin.GUI
{
    public partial class Frm_Usuarios : Form
    {
        private CalendarioEntities Contexto;
        private usuarios usuario_update;

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void tabsUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabsUsuarios.SelectedIndex)
            {
                case 0: lblTitulo.Text = "Agregar Usuario"; break;
                case 1: lblTitulo.Text = "Modificar Usuario"; break;
                case 2: lblTitulo.Text = "Eliminar Usuario"; break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarContraseñas(txbContraseña1, txbContraseña2) == true && ValidarCamposAgregar() == true) 
                    AgregarUsuario();
            }
            catch(Exception ex)
            {
                var excep = ex;
                StringBuilder Mensaje = new StringBuilder();
                while (excep != null)
                {
                    Mensaje.AppendLine(excep.Message + Environment.NewLine); 
                    excep = excep.InnerException;
                }

                MessageBox.Show(Mensaje.ToString());
            }
        }
        private void AgregarUsuario()
        {
            usuarios new_user = new usuarios();
            new_user.nombre = txbNombre.Text;
            new_user.contraseña = txbContraseña1.Text;
            new_user.id_tipousuario = ((tipos_usuario)(cbTipoUsuario.SelectedItem)).id_tipousuario;
            new_user.activo = "S";

            Contexto.usuarios.AddObject(new_user);
            Contexto.SaveChanges();

            MessageBox.Show("Usuario Agregado Con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarUsuarios();
        }
        private bool ValidarContraseñas(TextBox txb1, TextBox txb2)
        {
            string sContraseña1 = txb1.Text.ToUpper();
            string sContraseña2 = txb2.Text.ToUpper();

            if (sContraseña1 == sContraseña2)
                return true;
            else
            {
                MessageBox.Show("Las contraseñas no conciden...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ValidarCamposAgregar()
        {
            if (txbNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre no puede estar vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbContraseña1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La contraseña no puede estar vacia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            Contexto = new CalendarioEntities(Modelos.UsuarioSistema.getConnectonString());
            List<tipos_usuario> lstTiposUsuarioAgregar = Contexto.tipos_usuario.ToList();
            List<tipos_usuario> lstTiposUsuarioModificar = Contexto.tipos_usuario.ToList();

            cbTipoUsuario.DataSource = lstTiposUsuarioAgregar;
            cbTipoUsuario.DisplayMember = "tipo_usuario";
            cbTipoUsuario.ValueMember = "id_tipousuario";

            cbTipoUsuarioMod.DataSource = lstTiposUsuarioModificar;
            cbTipoUsuarioMod.DisplayMember = "tipo_usuario";
            cbTipoUsuarioMod.ValueMember = "id_tipousuario";

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<usuarios> lstUsuariosModificar = Contexto.usuarios.ToList().FindAll(o => o.activo == "S").ToList();
            List<usuarios> lstUsuariosEliminar = Contexto.usuarios.ToList().FindAll(o => o.activo == "S").ToList();
            
            cbNombreUsuario.DataSource = lstUsuariosModificar;
            cbNombreUsuario.DisplayMember = "nombre";

            cbUsuarioEliminar.DataSource = lstUsuariosEliminar;
            cbUsuarioEliminar.DisplayMember = "nombre";
        }

        private void cbNombreUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuario_update = (usuarios)cbNombreUsuario.SelectedItem;
            txbContraseñaMod1.Text = usuario_update.contraseña;
            txbContraseñaMod2.Text = usuario_update.contraseña;
            cbTipoUsuarioMod.SelectedValue = usuario_update.id_tipousuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarContraseñas(txbContraseñaMod1, txbContraseñaMod2) && ValidarCamposModificar())
                    Modificar();
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

                MessageBox.Show(Mensaje.ToString());
            }
        }

        private void Modificar()
        {            
            usuario_update.contraseña = txbContraseñaMod1.Text;
            usuario_update.id_tipousuario = ((tipos_usuario)cbTipoUsuarioMod.SelectedItem).id_tipousuario;

            usuarios usuario_actualizado = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == usuario_update.id_usuario);
            usuario_actualizado.contraseña = txbContraseñaMod1.Text;
            usuario_actualizado.id_tipousuario = usuario_update.id_tipousuario;

            Contexto.SaveChanges();
            MessageBox.Show("Modificado correctmente");
        }
        private bool ValidarCamposModificar()
        {
            if (txbContraseñaMod1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La contraseña no puede estar vacia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidarEliminar())
                    Eliminar();
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

                MessageBox.Show(Mensaje.ToString());
            }
        }
        private void Eliminar()
        {
            long idusuario = ((usuarios)cbUsuarioEliminar.SelectedItem).id_usuario;

            usuarios usuario_delete = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == idusuario);
            foreach (eventos evento in usuario_delete.eventos)
            {
                evento.activo = false;
            }
            usuario_delete.activo = "N";

            Contexto.SaveChanges();

            MessageBox.Show("Registro eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarUsuarios();
        }
        private bool ValidarEliminar()
        {
            DialogResult dr = 
                MessageBox.Show("¿Seguro que desea eliminar este usuario y sus eventos programados?", 
                                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                return true;

            return false;
        }
    }
}
