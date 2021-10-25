using Datos.Servidor;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AdminEspecialidad
    {
        public static DataTable Listar()
        {
            string consultaSQL = "SELECT Id,Nombre FROM dbo.Especialidad";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Especialidad");

            return dataSet.Tables["Especialidad"];
        }

        public static DataTable TraerUno(int id)
        {
            string consultaSQL = "SELECT Id,Nombre WHERE Id=@Id FROM dbo.Especialidad";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Especialidad");

            return dataSet.Tables["Especialidad"];
        }

        public static int Crear(Especialidad especialidad)
        {
            string insertSql = "INSERT dbo.Especialidad (Nombre) VALUES (@Nombre)";

            SqlCommand comando = new SqlCommand(insertSql, AdminDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especialidad.Nombre;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
