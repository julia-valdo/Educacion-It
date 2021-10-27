using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsDataReader
{
    public partial class FormException : Form
    {
        public FormException()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 10;
            try //Codigo ejecutable
            {
                int resultado = valor2 / valor1;
            }
            catch (DivideByZeroException exception) //Tratamiento de la exception personalizada
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception) //Tratamiento de la exception generica
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDemoExceptionSQL_Click(object sender, EventArgs e)
        {
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {     
                string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

                SqlCommand comando = new SqlCommand(consultaSQL, conexion);
                SqlDataReader reader;
                conexion.Open();
                reader = comando.ExecuteReader();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally // --> Ocurre siempre <-- Generalmente se usa para el control de recursos
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnDemoThrow_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Ocurrio un error.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ejemplo de Throw: " + exception.Message);
            }            
        }
    }
}
