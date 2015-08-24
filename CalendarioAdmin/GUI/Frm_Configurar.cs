using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalendarioAdmin.Entity;
using MySql.Data.MySqlClient;

namespace CalendarioAdmin.GUI
{
    public partial class Frm_Configurar : Form
    {
        private string sBaseDeDatos;

        public Frm_Configurar()
        {
            InitializeComponent();
        }

        private void Frm_Configurar_Load(object sender, EventArgs e)
        {
            txbServidor.Text = Properties.Settings.Default.Servidor;
            nudPuerto.Value = Properties.Settings.Default.Puerto;
            txbUsuario.Text = Properties.Settings.Default.Usuario;
            txbContraseña.Text = Properties.Settings.Default.Contraseña;
            sBaseDeDatos = Properties.Settings.Default.BaseDeDatos;

            ComprobarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Servidor = txbServidor.Text;
            Properties.Settings.Default.Puerto = Convert.ToInt32(nudPuerto.Value);
            Properties.Settings.Default.Usuario = txbUsuario.Text;
            Properties.Settings.Default.Contraseña = txbContraseña.Text;
            Properties.Settings.Default.BaseDeDatos = sBaseDeDatos;
            Properties.Settings.Default.Save();

            MessageBox.Show("Los datos se han gurdado con exito!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cbBaseDeDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBaseDeDatos.DataSource != null)
            {
                sBaseDeDatos = cbBaseDeDatos.SelectedItem.ToString();
            }
            else
            {
                sBaseDeDatos = string.Empty;
            }
        }

        private void cbBaseDeDatos_Click(object sender, EventArgs e)
        {
            ComprobarConexion();
        }
        private void ComprobarConexion()
        {
            string sConnectionString = string.Format("Server={0};Port={1};"+
                                                     "Uid={2};Pwd={3};",
                                                      txbServidor.Text, nudPuerto.Value, 
                                                      txbUsuario.Text, txbContraseña.Text);
            MySqlConnection myConn = new MySqlConnection(sConnectionString);

            try
            {
                myConn.Open();
                MySqlCommand Comando = new MySqlCommand();
                Comando.Connection = myConn;
                Comando.CommandText = "SHOW DATABASES";
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Comando;

                DataTable TablaDatabases = new DataTable();
                Adapter.Fill(TablaDatabases);

                List<string> lstDataBases = new List<string>();
                foreach (DataRow fila in TablaDatabases.Rows)
                {
                    lstDataBases.Add(fila[0].ToString());
                }

                myConn.Close();

                cbBaseDeDatos.DataSource = lstDataBases;
                cbBaseDeDatos.SelectedText = sBaseDeDatos;
            }
            catch
            {
                cbBaseDeDatos.DataSource = null;
            }
        }
    }
}
