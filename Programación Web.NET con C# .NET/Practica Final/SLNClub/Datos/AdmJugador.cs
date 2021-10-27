using Datos.Models;
using Datos.Servidor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AdmJugador
    {
        public static List<Jugador> Listar()
        {
            string consultaSql = "SELECT Id, Nombre, Apellido, FechaNacimiento, Puesto From dbo.Jugador";
            SqlCommand comando = new SqlCommand(consultaSql, AdmDB.ConectarBase());
            SqlDataReader reader = comando.ExecuteReader();
            List<Jugador> lista = new List<Jugador>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Jugador()
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                            Puesto = reader["Puesto"].ToString()
                        }
                    );
            }
            AdmDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }

        public static DataTable ListarPuestos()
        {
            string consultaSQL = "SELECT DISTINCT Puesto FROM dbo.Jugador";
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdmDB.ConectarBase());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Jugador");
            return dataSet.Tables["Jugador"];
        }

        public static DataTable TraerJugadores(string puesto)
        {
            string consultaSQL = "SELECT Id, Nombre, Apellido, FechaNacimiento, Puesto FROM dbo.Jugador WHERE Puesto=@Puesto";
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdmDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = puesto;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Puesto");
            return dataSet.Tables["Puesto"];
        }

        public static int Insertar(Jugador jugador)
        {
            string insertSql = "INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Puesto)";
            SqlCommand comando = new SqlCommand(insertSql, AdmDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = jugador.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = jugador.Apellido;
            comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            comando.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Modificar(Jugador jugador)
        {
            string updateSql = "UPDATE dbo.Jugador SET Nombre=@Nombre, Apellido=@Apellido, FechaNacimiento=@FechaNacimiento, Puesto=@Puesto WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(updateSql, AdmDB.ConectarBase());

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = jugador.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = jugador.Apellido;
            comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            comando.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = jugador.Id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Eliminar(int id)
        {
            string insertSql = "DELETE FROM dbo.Jugador WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(insertSql, AdmDB.ConectarBase());
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            int filasAfectadas = comando.ExecuteNonQuery();
            AdmDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
