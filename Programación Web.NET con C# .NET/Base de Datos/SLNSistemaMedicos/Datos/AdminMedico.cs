using Datos.Servidor;
using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AdminMedico
    {
        public static List<Medico> Listar()
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            SqlDataReader reader;

            reader = comando.ExecuteReader();

            List<Medico> lista = new List<Medico>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Medico()
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            NroMatricula = (int)reader["NroMatricula"],
                            EspecialidadId = (int)reader["EspecialidadId"]
                        }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }

        public static DataTable Listar(int idEspecialidad)
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE EspecialidadId=@EspecialidadId";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = idEspecialidad;

            DataSet dataSet= new DataSet();

            adapter.Fill(dataSet, "Medico");

            return dataSet.Tables["Medico"];
        }

        public static DataTable TraerUno(int id)
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId WHERE EspecialidadId=@EspecialidadId FROM dbo.Medico";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = id;

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Medico");

            return dataSet.Tables["Medico"];
        }

        public static int Crear(Medico medico)
        {
            string insertSql = "INSERT dbo.Medico (Nombre, Apellido, NroMatricula, EspecialidadId) VALUES (@Nombre, @Apellido, @NroMatricula, @EspecialidadId)";

            SqlCommand comando = new SqlCommand(insertSql, AdminDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            comando.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            comando.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = medico.EspecialidadId;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Eliminar(int id)
        {
            string insertSql = "DELETE FROM dbo.Medico WHERE Id=@Id";

            SqlCommand comando = new SqlCommand(insertSql, AdminDB.ConectarBase());

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Modificar(Medico medico)
        {
            string insertSql = "UPDATE dbo.Medico SET Nombre=@Nombre, Apellido=@Apellido, NroMatricula=@NroMatricula, EspecialidadId=@EspecialidadId WHERE Id=@Id";

            SqlCommand comando = new SqlCommand(insertSql, AdminDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            comando.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            comando.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = medico.EspecialidadId;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = medico.Id;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
