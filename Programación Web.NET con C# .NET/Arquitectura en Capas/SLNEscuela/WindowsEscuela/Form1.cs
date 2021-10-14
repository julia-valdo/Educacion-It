using System;
using System.Windows.Forms;
using LibreariaEscuela.Models;

namespace WindowsEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor("Profesor", "Jirafales", 12345678, "Maestro", new DateTime(1934, 06, 15));
            MessageBox.Show(profesor.Nombre + " " + profesor.Apellido + ", " + profesor.Titulo + ". DNI: " + profesor.DNI + ". Fecha de nacimiento: " + profesor.FechaNacimiento.ToShortDateString());
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno("El", "Chavo", 11111111, 8, new DateTime(1971, 06, 20));
            MessageBox.Show(alumno.Nombre + " " + alumno.Apellido + ", " + alumno.NroLegajo + ". DNI: " + alumno.DNI + ". Fecha de nacimiento: " + alumno.FechaNacimiento.ToShortDateString());
        }
    }
}
