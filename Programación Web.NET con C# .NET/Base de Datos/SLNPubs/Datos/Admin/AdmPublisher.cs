using Datos.Models;
using Datos.Servidor;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
        public static List<Publisher> Listar()
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            return LeerBD(comando);
        }

        public static List<Publisher> Listar(string city)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;

            return LeerBD(comando);
        }

        public static List<Publisher> Listar(string city, string state)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city AND state IS NULL OR state=@state";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;

            return LeerBD(comando);
        }

        public static List<Publisher> Listar(string city, string state, string country)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city AND state IS NULL OR state=@state AND country=@country";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
            comando.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = country;
            return LeerBD(comando);
        }

        private static List<Publisher> LeerBD(SqlCommand comando)
        {
            SqlDataReader reader = comando.ExecuteReader();

            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Publisher()
                        {
                            Pub_id = reader["pub_id"].ToString(),
                            Pub_name = reader["pub_name"].ToString(),
                            City = reader["city"].ToString(),
                            State = reader["state"].ToString(),
                            Country = reader["country"].ToString(),
                        }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }
    }
}
