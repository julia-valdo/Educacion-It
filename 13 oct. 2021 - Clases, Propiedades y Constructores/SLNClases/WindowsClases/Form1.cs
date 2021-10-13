using System;
using System.Windows.Forms;
using WindowsClases.Models;

namespace WindowsClases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiarLstBox()
        {
            lstMostrar.Items.Clear();
        }

        private void btnCrearCelular_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Celular celular1 = new Celular("Samsung", "A11", "Argentina", 64, 24499.00);
            Celular celular2 = new Celular();
            celular2.Marca = "Apple";
            celular2.Modelo = "iPhone 12";
            celular2.Origen = "China";
            celular2.Almacenamiento = 64;
            celular2.Precio = 239999.00;

            lstMostrar.Items.Add(celular1.Marca + " " + celular1.Modelo + ", origen: " + celular1.Origen + ", almacenamiento: " + celular1.Almacenamiento + "GB, precio: $" + celular1.Precio);
            lstMostrar.Items.Add(celular2.Marca + " " + celular2.Modelo + ", origen: " + celular2.Origen + ", almacenamiento: " + celular2.Almacenamiento + "GB, precio: $" + celular2.Precio);
        }

        private void btnCrearPerro_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Perro perro1 = new Perro("Miko", "Pastor Alemán", "grande", "inteligente", 30);
            Perro perro2 = new Perro();
            perro2.Nombre = "Velador";
            perro2.Raza = "Bull Terrier Inglés";
            perro2.Tamaño = "Mediano";
            perro2.Caracter = "Sociable";
            perro2.Peso = 30;

            lstMostrar.Items.Add(perro1.Nombre + ": " + perro1.Raza + ": " + perro1.Tamaño + ", " + perro1.Caracter + ". Peso promedio: " + perro1.Peso + "Kg.");
            lstMostrar.Items.Add(perro2.Nombre + ": " + perro2.Raza + ": " + perro2.Tamaño + ", " + perro2.Caracter + ". Peso promedio: " + perro2.Peso + "Kg.");
        }

        private void btnCrearMedicamento_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Medicamento medicamento1 = new Medicamento("Actron", "Ibuprofeno", "Antiinflamatorio", "Bayer", new DateTime(2022, 07, 22));
            Medicamento medicamento2 = new Medicamento();
            medicamento2.Marca = "Amoxidal Dúo";
            medicamento2.Droga = "Amoxicilina";
            medicamento2.Grupo = "Antibiótico";
            medicamento2.Laboratorio = "Roemmers";
            medicamento2.FechaVencimiento = new DateTime(2023, 11, 03);

            lstMostrar.Items.Add(medicamento1.Marca + ", " + medicamento1.Droga + ". " + "Grupo: " + medicamento1.Grupo + ". Laboratorio: " + medicamento1.Laboratorio + ". Consumir antes del: " + medicamento1.FechaVencimiento.ToShortDateString());
            lstMostrar.Items.Add(medicamento2.Marca + ", " + medicamento2.Droga + ". " + "Grupo: " + medicamento2.Grupo + ". Laboratorio: " + medicamento2.Laboratorio + ". Consumir antes del: " + medicamento2.FechaVencimiento.ToShortDateString());
        }

        private void btnCrearTeclado_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Teclado teclado1 = new Teclado("Redragon", "Kumara", "mecánico", 6499);
            Teclado teclado2 = new Teclado();
            teclado2.Marca = "Genius";
            teclado2.Modelo = "Smart KB-102";
            teclado2.Tipo = "membrana";
            teclado2.Precio = 784.67;

            lstMostrar.Items.Add("Teclado: " + teclado1.Marca + " " + teclado1.Modelo + ", " + teclado1.Tipo + ". Precio: $" + teclado1.Precio);
            lstMostrar.Items.Add("Teclado: " + teclado2.Marca + " " + teclado2.Modelo + ", " + teclado2.Tipo + ". Precio: $" + teclado2.Precio);
        }

        private void btnCrearStreamer_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Streamer streamer1 = new Streamer("Ibai", "español", 26, 8100000);
            Streamer streamer2 = new Streamer();
            streamer2.Usuario = "Coscu";
            streamer2.Nacionalidad = "argentino";
            streamer2.Edad = 30;
            streamer2.NroSeguidores = 3200000;

            lstMostrar.Items.Add(streamer1.Usuario + ", " + streamer1.Nacionalidad + ", " + streamer1.Edad + " años. Número de seguidores: " + streamer1.NroSeguidores);
            lstMostrar.Items.Add(streamer2.Usuario + ", " + streamer2.Nacionalidad + ", " + streamer2.Edad + " años. Número de seguidores: " + streamer2.NroSeguidores);
        }

        private void btnCrearCrema_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Crema crema1 = new Crema("Neutrogena", "Exfoliante facial", 533.62, 100);
            Crema crema2 = new Crema();
            crema2.Marca = "Veganis";
            crema2.Tipo = "Humectante corporal";
            crema2.Precio = 105.61;
            crema2.Contenido = 500;

            lstMostrar.Items.Add(crema1.Tipo + " " + crema1.Marca + ", contendio:" + crema1.Contenido + " g. Precio: $" + crema1.Precio);
            lstMostrar.Items.Add(crema2.Tipo + " " + crema2.Marca + ", contendio:" + crema2.Contenido + " g. Precio: $" + crema2.Precio);
        }

        private void btnCrearPresidente_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Presidente presidente1 = new Presidente("Bernardino", "Rivadavia", "Argentina", "Partido Unitario", new DateTime(1826, 02, 08), new DateTime(1827, 06, 27));
            Presidente presidente2 = new Presidente();
            presidente2.Nombre = "George";
            presidente2.Apellido = "Washington";
            presidente2.Pais = "Estado Unidos";
            presidente2.Partido = "Independiente";
            presidente2.InicioMandato = new DateTime(1789, 04, 30);
            presidente2.FinMandato = new DateTime(1797, 03, 04);

            lstMostrar.Items.Add(presidente1.Nombre + " " + presidente1.Apellido + ", " + presidente1.Pais + ". Partido: " + presidente1.Partido + ". Mandato: desde " + presidente1.InicioMandato.ToShortDateString() + " hasta " + presidente1.FinMandato.ToShortDateString());
            lstMostrar.Items.Add(presidente2.Nombre + " " + presidente2.Apellido + ", " + presidente2.Pais + ". Partido: " + presidente2.Partido + ". Mandato: desde " + presidente2.InicioMandato.ToShortDateString() + " hasta " + presidente2.FinMandato.ToShortDateString());

        }

        private void btnCrearPlanta_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Planta planta1 = new Planta("Margarita", "Asteraceae", "Magnoliopsida", "Asterales");
            Planta planta2 = new Planta();
            planta2.Nombre = "Aloe vera";
            planta2.Familia = "Asphodelaceae";
            planta2.Clase = "Liliopsida";
            planta2.Orden = "Asparagales";

            lstMostrar.Items.Add(planta1.Nombre + ", familia: " + planta1.Familia + ", clase: " + planta1.Clase + ", orden: " + planta1.Orden);
            lstMostrar.Items.Add(planta2.Nombre + ", familia: " + planta2.Familia + ", clase: " + planta2.Clase + ", orden: " + planta2.Orden);
        }

        private void btnCrearBebida_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            Bebida bebida1 = new Bebida("Sprite", "gaseosa", 39, 9);
            Bebida bebida2 = new Bebida();
            bebida2.Nombre = "Té";
            bebida2.Tipo = "infusión";
            bebida2.Calorias = 1;
            bebida2.Sodio = 4;

            lstMostrar.Items.Add(bebida1.Nombre + ", " + bebida1.Tipo + ". Calorias cada 100 g: " + bebida1.Calorias + ". Sodio cada 100 g: " + bebida1.Sodio + " mg.");
            lstMostrar.Items.Add(bebida2.Nombre + ", " + bebida2.Tipo + ". Calorias cada 100 g: " + bebida2.Calorias + ". Sodio cada 100 g: " + bebida2.Sodio + " mg.");
        }

        private void btnCrearSistemaOperativo_Click(object sender, EventArgs e)
        {
            limpiarLstBox();
            SistemaOperativo sistema1 = new SistemaOperativo("Android", "Google", "Linux", new DateTime(2008, 09, 23));
            SistemaOperativo sistema2 = new SistemaOperativo();
            sistema2.Nombre = "iOS";
            sistema2.Desarrollador = "Apple";
            sistema2.Nucleo = "XNU";
            sistema2.Lanzamiento = new DateTime(2007, 06,29);

            lstMostrar.Items.Add(sistema1.Nombre + " by " + sistema1.Desarrollador + ". Lanzamiento: " + sistema1.Lanzamiento.ToShortDateString() + ". Nucleo: " + sistema1.Nucleo);
            lstMostrar.Items.Add(sistema2.Nombre + " by " + sistema2.Desarrollador + ". Lanzamiento: " + sistema2.Lanzamiento.ToShortDateString() + ". Nucleo: " + sistema2.Nucleo);
        }
    }
}
