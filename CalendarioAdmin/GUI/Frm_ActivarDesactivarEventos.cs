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
    public partial class Frm_ActivarDesactivarEventos : Form
    {
        private CalendarioEntities Contexto;
        private List<eventos> lstEventosActivos, lstEventosInactivos;

        public Frm_ActivarDesactivarEventos()
        {
            InitializeComponent();
        }

        private void Frm_ActivarDesactivarEventos_Load(object sender, EventArgs e)
        {
            try
            {
                Contexto = new CalendarioEntities(Modelos.UsuarioSistema.getConnectonString());
                CargarControles();
            }
            catch(Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void MostrarExcepcion(Exception ex)
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

        private void CargarControles()
        {
            long id_usuario = Modelos.UsuarioSistema.IdUsuario;
            List<eventos> lstEventos = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario).eventos.ToList();

            lstEventosActivos = lstEventos.FindAll(o => o.activo == true);
            lstEventosInactivos = lstEventos.FindAll(o => o.activo == false);

            gridActivos.DataSource = lstEventosActivos;
            gvActivos.BestFitColumns();

            gridInactivos.DataSource = lstEventosInactivos;
            gvInactivos.BestFitColumns();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                Desactivar();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Desactivar()
        {
            if (lstEventosActivos.Count != 0)
            {
                int indice = gvActivos.GetSelectedRows()[0];
                eventos desactivar = (eventos)gvActivos.GetRow(indice);
                lstEventosActivos.Remove(desactivar);
                lstEventosInactivos.Add(desactivar);

                gridActivos.RefreshDataSource();
                gridInactivos.RefreshDataSource();
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                Activar();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void Activar()
        {
            if (lstEventosInactivos.Count != 0)
            {
                int indice = gvInactivos.GetSelectedRows()[0];
                eventos activar = (eventos)gvInactivos.GetRow(indice);
                lstEventosActivos.Add(activar);
                lstEventosInactivos.Remove(activar);

                gridActivos.RefreshDataSource();
                gridInactivos.RefreshDataSource();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Guardar()
        {
            foreach(eventos activar in lstEventosActivos)
            {
                eventos evento = Contexto.eventos.FirstOrDefault(o => o.id_evento == activar.id_evento);
                evento.activo = true;
            }
            foreach (eventos desactivar in lstEventosInactivos)
            {
                eventos evento = Contexto.eventos.FirstOrDefault(o => o.id_evento == desactivar.id_evento);
                evento.activo = false;
            }

            Contexto.SaveChanges();

            MessageBox.Show("Cambios realizados con exito...", "Activar / Desactivar", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
