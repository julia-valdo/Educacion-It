using System.Data.SqlClient;

namespace Datos.Servidor
{
    internal static class AdmDB
    {
        internal static SqlConnection ConectarBase()
        {
            string cadena = Datos.Properties.Settings.Default.KeyDBTransporte;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;
        }
    }
}
