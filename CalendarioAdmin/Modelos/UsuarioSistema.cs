
namespace CalendarioAdmin.Modelos
{
    public static class UsuarioSistema
    {
        public static long IdUsuario = 0;
        public static string sNombreSusuario = string.Empty;

        public static string getConnectonString()
        {
            string sConnectionString =
            string.Format(@"metadata=res://*/Entity.Model.csdl|res://*/Entity.Model.ssdl|res://*/Entity.Model.msl;provider=MySql.Data.MySqlClient;provider connection string='server={0};user id={1};password={2};database={3};port={4}'"
                            , Properties.Settings.Default.Servidor
                            , Properties.Settings.Default.Usuario
                            , Properties.Settings.Default.Contraseña
                            , Properties.Settings.Default.BaseDeDatos
                            , Properties.Settings.Default.Puerto);

            return sConnectionString;
        }
    }
}
