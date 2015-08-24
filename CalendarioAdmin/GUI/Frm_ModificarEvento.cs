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
    public partial class Frm_ModificarEvento : Form
    {
        private CalendarioEntities Contexto;
        private usuarios usuario;
        public Frm_ModificarEvento()
        {
            InitializeComponent();
        }

        private void Frm_ModificarEvento_Load(object sender, EventArgs e)
        {
            try
            {
                Contexto = new CalendarioEntities(UsuarioSistema.getConnectonString());
                usuario = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == UsuarioSistema.IdUsuario);
                CargarEventosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void CargarEventosGrid()
        {
            //Utilizamos la variable global "usuario"
            List<eventos> lstEventos = usuario.eventos.ToList();
            lstEventos =  lstEventos.FindAll(o => o.activo == true);
            gridEventos.DataSource = lstEventos;
            gvEventos.BestFitColumns();
        }

        private void gvEventos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int indiceSeleccionado = gvEventos.GetSelectedRows()[0];
            eventos eventoSeleccionado = (eventos)gvEventos.GetRow(indiceSeleccionado);
            PoblarControles(eventoSeleccionado);
        }

        private void PoblarControles(eventos evento)
        {
            txbNombre.Text = evento.nombre;
            txbDescripcion.Text = evento.descripcion;
            txbCantidad.Text = evento.cantidad.ToString();
            txbBanco.Text = evento.banco;
            txbCuantaBancaria.Text = evento.cuenta_bancaria;
            txbNotas.Text = evento.notas;

            if (evento.es_semanal == true)
            {
                rbPorSemana.Checked = true;
                switch (evento.dia_semana)
                {
                    case "L": cbDiaSemana.SelectedIndex = 1; break;
                    case "M": cbDiaSemana.SelectedIndex = 2; break;
                    case "X": cbDiaSemana.SelectedIndex = 3; break;
                    case "J": cbDiaSemana.SelectedIndex = 4; break;
                    case "V": cbDiaSemana.SelectedIndex = 5; break;
                    case "S": cbDiaSemana.SelectedIndex = 6; break;
                }
            }
            else
            {
                rbPorDia.Checked = true;
                nudDiaEvento.Value = (Byte)evento.dia_limite;
            }

            switch (evento.tipos_evento.id_tipo_evento)
            {
                case "T": rbTodos.Checked = true; break;
                case "P": rbPares.Checked = true; break;
                case "N": rbNones.Checked = true; break;
            }
        }

        private void rbPorDia_CheckedChanged(object sender, EventArgs e)
        {
            nudDiaEvento.Enabled = rbPorDia.Checked;
        }

        private void rbPorSemana_CheckedChanged(object sender, EventArgs e)
        {
            cbDiaSemana.Enabled = rbPorSemana.Checked;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarModificacion() == true)
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
            long idevento = ObtenerEventoSeleccionado();
            eventos evento_update = Contexto.eventos.FirstOrDefault(o => o.id_evento == idevento);

            evento_update.nombre = txbNombre.Text;
            evento_update.descripcion = txbDescripcion.Text;
            evento_update.cantidad = Convert.ToDecimal(txbCantidad.Text);
            evento_update.banco = txbBanco.Text;
            evento_update.cuenta_bancaria = txbBanco.Text;
            evento_update.notas = txbNotas.Text;
            
            if (rbPorDia.Checked == true)
            {
                evento_update.es_semanal = false;
                evento_update.dia_limite = Convert.ToByte(nudDiaEvento.Value);
            }
            else
            {
                evento_update.es_semanal = true;
                switch (cbDiaSemana.SelectedIndex)
                {
                    case 1: evento_update.dia_semana = "L"; break;
                    case 2: evento_update.dia_semana = "M"; break;
                    case 3: evento_update.dia_semana = "X"; break;
                    case 4: evento_update.dia_semana = "J"; break;
                    case 5: evento_update.dia_semana = "V"; break;
                    case 6: evento_update.dia_semana = "S"; break;
                }
            }

            if (rbTodos.Checked == true)
            {
                evento_update.id_tipo_evento = "T";
            }
            else if (rbPares.Checked == true)
            {
                evento_update.id_tipo_evento = "P";
            }
            else
            {
                evento_update.id_tipo_evento = "N";
            }

            Contexto.SaveChanges();

            MessageBox.Show("El evento ha sido modificado...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private long ObtenerEventoSeleccionado()
        {
            int indice = gvEventos.GetSelectedRows()[0];
            long idevento = ((eventos)gvEventos.GetRow(indice)).id_evento;
            return (idevento);
        }
        private bool ValidarModificacion()
        {
            DialogResult dr = 
                MessageBox.Show("¿Los datos son correctos?", "Validar", 
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
