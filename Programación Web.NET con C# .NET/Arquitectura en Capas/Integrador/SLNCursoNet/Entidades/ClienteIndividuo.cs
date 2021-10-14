﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            CUIT = cuit;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
