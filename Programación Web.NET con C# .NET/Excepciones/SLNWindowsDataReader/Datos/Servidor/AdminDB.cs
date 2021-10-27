using System.Data.SqlClient;

namespace Datos.Servidor
{
    internal static class AdminDB
    {
        /// <summary>
        /// Permite establecer la conexion con la base Northwind
        /// </summary>
        /// <returns> Objeto de conexion abierto </returns>
        internal static SqlConnection ConectarBase()
        {
            string cadena = Datos.Properties.Settings.Default.KeyDBNorthwind;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;
        }
    }
}
