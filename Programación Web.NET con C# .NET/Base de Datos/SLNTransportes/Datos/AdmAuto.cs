using Datos.Servidor;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AdmAuto
    {
        public static List<Auto> Listar()
        {
            string consultaSql = "SELECT ID, Marca, Modelo, Matricula, Precio FROM dbo.Auto";

            SqlCommand comando = new SqlCommand(consultaSql, AdmDB.ConectarBase());

            SqlDataReader reader = comando.ExecuteReader();

            List<Auto> lista = new List<Auto>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Auto()
                        {
                            Id = (int)reader["ID"],
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Matricula = reader["Matricula"].ToString(),
                            Precio = Convert.ToDecimal(reader["Precio"])
                        }
                    );
            }

            AdmDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }

        public static DataTable ListarMarcas()
        {
            string consultaSQL = "SELECT DISTINCT Marca FROM dbo.Auto";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdmDB.ConectarBase());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Auto");

            return dataSet.Tables["Auto"];
        }

        public static DataTable Listar(string marca)
        {
            string consultaSql = "SELECT ID, Marca, Modelo, Matricula, Precio FROM dbo.Auto WHERE Marca=@Marca";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, AdmDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50).Value = marca;

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Auto");

            return dataSet.Tables["Auto"];
        }

        public static int Insertar(Auto auto)
        {
            string insertSql = "INSERT dbo.Auto (Marca, Modelo, Matricula, Precio) VALUES (@Marca, @Modelo, @Matricula, @Precio)";

            SqlCommand comando = new SqlCommand(insertSql, AdmDB.ConectarBase());

            comando.Parameters.Add("@Marca", SqlDbType.VarChar, 50).Value = auto.Marca;
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar, 50).Value = auto.Modelo;
            comando.Parameters.Add("@Matricula", SqlDbType.Char, 6).Value = auto.Matricula;
            comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = auto.Precio;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Modificar(Auto auto)
        {
            string updateSql = "UPDATE dbo.Auto SET Marca=@Marca, Modelo=@Modelo, Matricula=@Matricula, Precio=@Precio WHERE ID=@ID";

            SqlCommand comando = new SqlCommand(updateSql, AdmDB.ConectarBase());

            comando.Parameters.Add("@Marca", SqlDbType.VarChar, 50).Value = auto.Marca;
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar, 50).Value = auto.Modelo;
            comando.Parameters.Add("@Matricula", SqlDbType.Char, 6).Value = auto.Matricula;
            comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = auto.Precio;
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = auto.Id;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Eliminar(int id)
        {
            string insertSql = "DELETE FROM dbo.Auto WHERE ID=@ID";

            SqlCommand comando = new SqlCommand(insertSql, AdmDB.ConectarBase());

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;

            int filasAfectadas = comando.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
