using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsDataReader.Models;

namespace WindowsDataReader
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void btnTraerCustomers_Click(object sender, EventArgs e)
        {
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            SqlConnection conexion = new SqlConnection(cadena);

            string consultaSQL = "SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers";

            SqlCommand comando = new SqlCommand(consultaSQL, conexion);

            SqlDataReader reader;

            conexion.Open();

            reader = comando.ExecuteReader();

            List<Customer> lista = new List<Customer>();
            while (reader.Read())
            {
                lista.Add
                    (
                        new Customer()
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            CompanyName = reader["CompanyName"].ToString(),
                            ContactName = reader["ContactName"].ToString(),
                            ContactTitle = reader["ContactTitle"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            Region = reader["Region"].ToString(),
                            PostalCode = reader["PostalCode"].ToString(),
                            Country = reader["Country"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Fax = reader["Fax"].ToString(),
                        }
                    );
            }

            conexion.Close();
            reader.Close();

            gridCustomers.DataSource = lista;
        }
    }
}
