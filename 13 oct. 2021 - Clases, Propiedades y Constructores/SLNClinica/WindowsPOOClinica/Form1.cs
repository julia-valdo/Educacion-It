using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPOOClinica.Models;

namespace WindowsPOOClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico("Julia", "Valdovinos", "A123");

            MessageBox.Show(medico.Nombre + " " + medico.Apellido + ", " + medico.Matricula);
        }

        private void btnCrearEnfermero_Click(object sender, EventArgs e)
        {
            Enfermero enfermero1 = new Enfermero("Pablo", "Lamponne", new DateTime(1998, 01, 21), "Calle Falsa 123");
            Enfermero enfermero2 = new Enfermero();
            enfermero2.Nombre = "Emilio";
            enfermero2.Apellido = "Ravenna";
            enfermero2.FechaNacimiento = new DateTime(1999, 03, 29);
            enfermero2.Domicilio = "Abbey Road 123";

            MessageBox.Show(enfermero1.Nombre + " " + enfermero1.Apellido + ", " + enfermero1.FechaNacimiento.ToShortDateString().ToString());
            MessageBox.Show(enfermero2.Nombre + " " + enfermero2.Apellido + ", " + enfermero2.FechaNacimiento.ToShortDateString().ToString());
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente1 = new Paciente("Federico", "Fritzenwalden", new DateTime(1964, 07, 17), "Av. Siempre Viva 123", 1);
            Paciente paciente2 = new Paciente();
            paciente2.Nombre = "Florencia";
            paciente2.Apellido = "Fazzarino";
            paciente2.FechaNacimiento = new DateTime(1999, 03, 29);
            paciente2.Domicilio = "Gran Vía 123";

            MessageBox.Show(paciente1.Nombre + " " + paciente1.Apellido + ", fecha de nacimiento: " + paciente1.FechaNacimiento.ToShortDateString() + ", domicilio: " + paciente1.Domicilio);
            MessageBox.Show(paciente2.Nombre + " " + paciente2.Apellido + ", fecha de nacimiento: " + paciente2.FechaNacimiento.ToShortDateString() + ", domicilio: " + paciente2.Domicilio);
        }

        private void btnCrearDirector_Click(object sender, EventArgs e)
        {
            Director director1 = new Director("Greta", "Van Beethoven", new DateTime(1999, 04, 11), "Calle 13");
            Director director2 = new Director();
            director2.Nombre = "Delfina";
            director2.Apellido = "Santillán Torres Oviedo";
            director2.FechaNacimiento = new DateTime(1999, 03, 29);
            director2.Domicilio = "5th Avenue 123";

            MessageBox.Show(director1.Nombre + " " + director1.Apellido + ", fecha de nacimiento: " + director1.FechaNacimiento.ToShortDateString().ToString() + ", domicilio: " + director1.Domicilio);
            MessageBox.Show(director2.Nombre + " " + director2.Apellido + ", fecha de nacimiento: " + director2.FechaNacimiento.ToShortDateString().ToString() + ", domicilio: " + director2.Domicilio);
        }

        private void btnCrearClinica_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica("Mayo", "Estados Unidos");

            MessageBox.Show("Clinica: " + clinica.Nombre + ", " + clinica.Domicilio);
        }
    }
}
