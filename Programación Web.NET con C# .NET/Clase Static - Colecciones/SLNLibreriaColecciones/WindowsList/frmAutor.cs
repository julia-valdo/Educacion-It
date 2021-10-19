using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsList
{
    public partial class frmAutor : Form
    {
        List<Autor> autores = new List<Autor>();

        public frmAutor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crearAutores();
            gridAutores.DataSource = autores;
        }

        private void crearAutores()
        {
            Autor autor1 = new Autor(1, "Shakespeare", "William", "Inglesa", "Stratford", new DateTime(1564, 04, 23));
            Autor autor2 = new Autor(2, "Borges", "Jorge Luis", "Argentina", "Buenos Aires", new DateTime(1899, 08, 24));

            autores.Add(autor1);
            autores.Add(autor2);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, txtNacionalidad.Text, txtCiudad.Text, Convert.ToDateTime(txtFechaNacimiento.Text));
            autores.Add(autor);

            gridAutores.DataSource = null;
            gridAutores.DataSource = autores;
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            List<Autor> autoresVecinos = new List<Autor>();
            foreach (Autor item in autores)
            {
                if (item.Ciudad == txtCiudad.Text)
                    autoresVecinos.Add(item);
            }
            gridAutores.DataSource = autoresVecinos;
        }
    }
}
