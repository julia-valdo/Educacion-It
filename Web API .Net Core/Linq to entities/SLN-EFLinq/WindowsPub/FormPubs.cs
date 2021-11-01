using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsPub.Data;

namespace WindowsPub
{
    public partial class FormPubs : Form
    {
        PubsContext context = new PubsContext();

        public FormPubs()
        {
            InitializeComponent();
        }

        private void btnTraerAutores_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         select a).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerAutoresPorCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = "Oakland";

            var lista = (from a in context.authors
                         where a.city == ciudad
                         select a).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            string id = "172-32-1176";

            var lista = (from a in context.authors
                         where a.au_id == id
                         select a).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerPublicadorPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = "New Moon Books";

            var lista = (from p in context.publishers
                         where p.pub_name == nombre
                         select p).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnMostrarListaSalesStores_Click(object sender, EventArgs e)
        {
            var lista = (from sa in context.sales
                         join st in context.stores
                         on sa.stor_id equals st.stor_id
                         select new
                         {
                             Id = sa.stor_id,
                             Nombre = st.stor_name,
                             Ciudad = st.stor_address,
                             NroOrden = sa.ord_num,
                             Fecha = sa.ord_date,
                             Cantidad = sa.qty,
                             Titulo = sa.title_id
                         }
                         ).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnMostrarListaEmployeePublishers_Click(object sender, EventArgs e)
        {
            var lista = (from em in context.employees
                         join p in context.publishers
                         on em.pub_id equals p.pub_id
                         select new
                         {
                            Nombre = em.fname,
                            Apellido = em.lname,
                            Publisher = p.pub_name
                         }
                         ).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnMostrarEmployeeMismoPaisPublisher_Click(object sender, EventArgs e)
        {
            string country = "Germany";

            var lista = (from em in context.employees
                         join p in context.publishers
                         on em.pub_id equals p.pub_id
                         where p.country == country
                         select new
                         {
                             Nombre = em.fname,
                             Apellido = em.lname,
                             Publisher = p.pub_name
                         }
                         ).ToList();

            gridPubs.DataSource = lista;
        }
    }
}
