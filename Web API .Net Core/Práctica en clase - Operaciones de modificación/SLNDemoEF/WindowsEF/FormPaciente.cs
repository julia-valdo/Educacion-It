using Datos.Admin;
using Datos.Models;
using System;
using System.Windows.Forms;

namespace WindowsEF
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        private void mostrarPacientes()
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                Nombre = "Julia",
                Apellido = "Valdovinos",
                FechaNacimiento = new DateTime(1998, 01, 21),
                NroHistoriaClinica = 1,
                MedicoId = 1
            };
            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas > 0)
                mostrarPacientes();
        }
    }
}
