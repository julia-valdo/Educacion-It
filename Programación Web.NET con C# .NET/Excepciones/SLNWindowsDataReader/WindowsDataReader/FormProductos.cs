using System;
using System.Windows.Forms;
//Para trabajar con SQL Server:
using System.Data.SqlClient;
using System.Collections.Generic;
using WindowsDataReader.Models;

namespace WindowsDataReader
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnTraerProductos_Click(object sender, EventArgs e)
        {
            //Una variable para leer la cadena de conexión en App.config:
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            //Crear un objeto de conexión:
            SqlConnection conexion = new SqlConnection(cadena);

            //Una variable con la consulta de SQL:
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            //Crear un objeto SqlCommand:
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);

            //Declarar un objeto SqlDataReader:
            SqlDataReader reader;

            //Abrir la conexion:
            conexion.Open();

            //Crear el reader:
            reader = comando.ExecuteReader();

            //Recorrer (leer) los datos de forma secuencial:
            List<Product> lista = new List<Product>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Product()
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = reader["ProductName"].ToString(),
                            SupplierID = (int)reader["SupplierID"],
                            CategoryID = (int)reader["CategoryID"],
                            QuantityPerUnit = reader["QuantityPerUnit"].ToString(),
                            UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                            UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]),
                            UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]),
                            ReorderLevel = Convert.ToInt16(reader["ReorderLevel"]),
                            Discontinued = (bool)reader["Discontinued"]
                        }
                    );
            }

            //Cerrar la conexion a la base de datos y cerrar el reader:
            conexion.Close();
            reader.Close();

            gridProductos.DataSource = lista;
        }
    }
}
