using Entidades.Models;
using System;
using System.Collections.Generic;

namespace Entidades.AdminPublicadores
{
    public static class AdminPublicador
    {
        public static List<Publicador> publicadores = new List<Publicador>()
            {
                new Publicador(1, "Valdovinos" , "Julia" , "Buenos Aires", new DateTime(1998, 01, 21)),
                new Publicador(2, "Addams", "Wednesday", "Santa Mónica", new DateTime(1980, 02, 12)),
                new Publicador(3, "Simpson", "Homer", "Springfield", new DateTime(1987, 04, 19))
            };

        public static List<Publicador> Listar()
        {
            return publicadores;
        }

        public static void Insertar(Publicador publicador)
        {
            publicadores.Add(publicador);
        }

        public static void Eliminar(int id)
        {
            publicadores.Remove(publicadores.Find(Publicador => Publicador.Id == id));
        }
    }
}
