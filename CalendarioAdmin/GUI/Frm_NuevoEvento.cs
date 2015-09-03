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
    public partial class Frm_NuevoEvento : Form
    {
        private usuarios usuario;
        private CalendarioEntities Contexto;
        private List<usuarios> LstUsuarios;

        public Frm_NuevoEvento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Guardar()
        {            
            eventos nuevo_evento = new eventos();

            nuevo_evento.activo = true;
            if (ValidarCampo(txbNombre, "Nombre") != true) 
                return;
            nuevo_evento.nombre = txbNombre.Text;

            if (ValidarCampo(txbDescripcion, "Descripción") != true)  
                return; 
            nuevo_evento.descripcion = txbDescripcion.Text; 

            if (ValidarCampo(txbCantidad, "Cantidad") != true)  
                return; 
            nuevo_evento.cantidad = Convert.ToDecimal(txbCantidad.Text);

            nuevo_evento.banco = txbBanco.Text;
            nuevo_evento.cuenta_bancaria = txbCuantaBancaria.Text;
            if (rbPorDia.Checked == true)
            {
                nuevo_evento.es_semanal = false;
                nuevo_evento.dia_limite = Convert.ToByte(nudDiaEvento.Value);
            }
            else
            {
                nuevo_evento.es_semanal = true;
                switch (cbDiaSemana.SelectedIndex)
                {
                    case 0: MessageBox.Show("Seleccine un dia de la semana...", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    case 1: nuevo_evento.dia_semana = "L"; break;
                    case 2: nuevo_evento.dia_semana = "M"; break;
                    case 3: nuevo_evento.dia_semana = "X"; break;
                    case 4: nuevo_evento.dia_semana = "J"; break;
                    case 5: nuevo_evento.dia_semana = "V"; break;
                    case 6: nuevo_evento.dia_semana = "S"; break;
                }
            }

            if (rbTodos.Checked == true) { nuevo_evento.tipos_evento = Contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "T"); }
            else if (rbPares.Checked == true) { nuevo_evento.tipos_evento = Contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "P"); }
            else { nuevo_evento.tipos_evento = Contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "N"); }

            nuevo_evento.notas = txbNotas.Text;

            if (ValidarDatos() == false)
                return;

            Contexto.eventos.AddObject(nuevo_evento);
            Contexto.SaveChanges();

            usuarios user;
            if (cbUsuarios.Enabled == false)
            {
                user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == UsuarioSistema.IdUsuario);
            }
            else
            {
                usuarios cb_user = (usuarios)cbUsuarios.SelectedItem;
                user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == cb_user.id_usuario);
            }
            user.eventos.Add(nuevo_evento);

            Contexto.SaveChanges();

            MessageBox.Show("El evento se ha dado de Alta con éxito!!!", "Nuevo Evento", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
        private bool ValidarCampo(TextBox txb, string sCampo)
        {
            if (txb.Text.Trim() == String.Empty)
            {
                string sError = string.Format("El campo '{0}' no puede estar vacio...", sCampo); 
                MessageBox.Show(sError, "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool ValidarDatos()
        {
            DialogResult dr = MessageBox.Show("¿Son datos correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return false;
            else
                return true;
        }
        private void rbPorDia_CheckedChanged(object sender, EventArgs e)
        {
            nudDiaEvento.Enabled = rbPorDia.Checked;
        }

        private void rbPorSemana_CheckedChanged(object sender, EventArgs e)
        {
            cbDiaSemana.Enabled = rbPorSemana.Checked;
        }

        private void Frm_NuevoEvento_Load(object sender, EventArgs e)
        {
            cbDiaSemana.SelectedIndex = 0;
            Contexto = new CalendarioEntities(Modelos.UsuarioSistema.getConnectonString());
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            LstUsuarios = Contexto.usuarios.Where(o => o.activo == "S").ToList();
            usuario = LstUsuarios.Find(o => o.id_usuario == UsuarioSistema.IdUsuario);

            cbUsuarios.DataSource = LstUsuarios;
            cbUsuarios.DisplayMember = "nombre";
            cbUsuarios.SelectedItem = usuario;

            if (usuario.id_tipousuario == "S")
                cbUsuarios.Enabled = true;
            else
                cbUsuarios.Enabled = false;
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 && textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
