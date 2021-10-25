using Datos.Servidor;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmCategory
    {
        public static DataTable Listar()
        {
            //Consultas SQL (query)
            string consultaSQL = "SELECT CategoryID,CategoryName FROM dbo.Categories";

            //Declarar y crear un SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            //Declarar y crear un DataSet
            DataSet ds = new DataSet();

            //Invocar al método Fill() --> se conecta a la base, ejecuta el SELECT, crea el DataTable y se desconecta
            adapter.Fill(ds, "Category");

            return ds.Tables["Category"];
        }

        public static DataTable TraerUna(int id)
        {
            string consultaSQL = "SELECT CategoryID,CategoryName FROM dbo.Categories WHERE CategoryID=@CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            //Declarar los parametros
            adapter.SelectCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Categoria");

            return ds.Tables["Categoria"];
        }
    }
}
