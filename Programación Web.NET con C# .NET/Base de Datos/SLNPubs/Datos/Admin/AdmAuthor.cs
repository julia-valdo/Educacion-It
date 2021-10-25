using Datos.Models;
using Datos.Servidor;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> Listar()
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            return LeerBD(comando);
        }

        public static List<Author> Listar(string city)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;

            return LeerBD(comando);
        }

        public static List<Author> Listar(string city, string state)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city AND state=@state";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
            return LeerBD(comando);
        }

        private static List<Author> LeerBD(SqlCommand comando)
        {
            SqlDataReader reader = comando.ExecuteReader();

            List<Author> lista = new List<Author>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Author()
                        {
                            Au_id = reader["au_id"].ToString(),
                            Au_lname = reader["au_lname"].ToString(),
                            Au_fname = reader["au_fname"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Address = reader["address"].ToString(),
                            City = reader["city"].ToString(),
                            State = reader["state"].ToString(),
                            Zip = reader["zip"].ToString(),
                            Contract = (bool)reader["contract"]
                        }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }

        public static DataTable ListarSoloCiudades()
        {
            string consultaSQL = "SELECT DISTINCT city FROM dbo.authors";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "City");

            return ds.Tables["City"];
        }

        public static DataTable ListarDataTable(string ciudad)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "City");

            return ds.Tables["City"];
        }
    }
}
