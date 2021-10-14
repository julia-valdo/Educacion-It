﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Vendedor(string nombre, string apellido, string dni, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
