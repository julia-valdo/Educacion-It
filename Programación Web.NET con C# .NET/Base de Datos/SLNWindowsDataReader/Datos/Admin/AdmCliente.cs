using Datos.Models;
using Datos.Servidor;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmCliente
    {
        public static DataTable Listar()
        {
            //TODO Falta implementar Listar() --> Devuelve todos los clientes en un DataTable
            return null;
        }

        public static int Insertar(Cliente cliente)
        {
            string insertSql = "INSERT dbo.Cliente (Nombre, Apellido, FechaNacimiento) VALUES (@Nombre, @Apellido, @FechaNacimiento)";

            SqlCommand comando = new SqlCommand(insertSql, AdminDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre; 
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
            comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = cliente.FechaNacimiento;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
