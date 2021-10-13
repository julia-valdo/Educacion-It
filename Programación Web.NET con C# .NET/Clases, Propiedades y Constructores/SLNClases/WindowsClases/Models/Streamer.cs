using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Streamer
    {
        public string Usuario { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }
        public int NroSeguidores { get; set; }

        public Streamer() { }

        public Streamer(string usuario, string nacionalidad, int edad, int nroSeguidores)
        {
            Usuario = usuario;
            Nacionalidad = nacionalidad;
            Edad = edad;
            NroSeguidores = nroSeguidores;
        }
    }
}
