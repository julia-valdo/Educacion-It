using System;

namespace WindowsClases.Models
{
    class Medicamento
    {
        public string Marca { get; set; }
        public string Droga { get; set; }        
        public string Grupo { get; set; }
        public string Laboratorio { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Medicamento() { }

        public Medicamento(string marca, string droga, string grupo, string laboratorio, DateTime fechaVencimiento)
        {
            Marca = marca;
            Droga = droga;
            Grupo = grupo;
            Laboratorio = laboratorio;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
