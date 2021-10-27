using Datos.Models;
using Datos.Servidor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmProduct
    {
        /// <summary>
        /// Trae todos los productos de la base Northwind
        /// </summary>
        /// <returns> Lista de productos </returns>
        public static List<Product> Listar()
        {
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            SqlDataReader reader;

            reader = comando.ExecuteReader();

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

            AdminDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }

        public static List<Product> Listar(int categoriaId)
        {
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products WHERE CategoryID=@CategoryID";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //Declarar el parametro de SQL Server:
            comando.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoriaId;

            SqlDataReader reader;

            reader = comando.ExecuteReader();

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

            AdminDB.ConectarBase().Close();
            reader.Close();

            return lista;
        }

        public static int Insertar(Product producto) 
        {
            return 0;
        }

        public static int Modificar(Product producto)
        {
            return 0;
        }

        public static int Eliminar(int idProducto)
        {
            return 0;
        }
    }
}
