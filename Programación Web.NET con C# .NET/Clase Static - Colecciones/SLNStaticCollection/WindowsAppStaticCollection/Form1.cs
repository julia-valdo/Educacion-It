using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsAppStaticCollection.DemoStatic;

namespace WindowsAppStaticCollection
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado = Calculadora.Suma(100, 10);
            MessageBox.Show("100 + 10 = " + resultado.ToString());
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Julia");
            MessageBox.Show(cliente1.Nombre + ", " + Cliente.NroInstancias.ToString());
            Cliente cliente2 = new Cliente("Lucia");
            MessageBox.Show(cliente2.Nombre + ", " + Cliente.NroInstancias.ToString());
            Cliente cliente3 = new Cliente("Marcos");
            MessageBox.Show(cliente3.Nombre + ", " + Cliente.NroInstancias.ToString());
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            llenarListaClientes();
            //Mostrar los clientes en el control gridClientes:
            gridClientes.DataSource = clientes;

        }

        private void llenarListaClientes()
        {
            clientes = new List<Cliente>();
            //Agrego elementos a la lista:
            clientes.Add(new Cliente("Julia"));
            clientes.Add(new Cliente("Lucia"));
            clientes.Add(new Cliente("Marcos"));
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            imprimirNombresClientes();
        }

        private void imprimirNombresClientes()
        {
            foreach (Cliente item in clientes)
            {
                lstMostrarNombres.Items.Add(item.Nombre);
            }
        }
    }
}
