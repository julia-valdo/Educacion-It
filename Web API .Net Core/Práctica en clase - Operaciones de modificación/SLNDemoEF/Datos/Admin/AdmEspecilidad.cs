using Datos.Data;
using Datos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Admin
{
    public static class AdmEspecilidad
    {
        static DbClinicaContext context = new DbClinicaContext();

        public static List<Especialidad> Listar()
        {
            return context.Especialidades.ToList();
        }

        public static List<Especialidad> TraerPorId(int id)
        {
            List<Especialidad> especialidades = (from e in context.Especialidades
                                    where e.Id == id
                                    select e).ToList();
            return especialidades;
        }

        public static int Insertar(Especialidad especialidad)
        {
            context.Especialidades.Add(especialidad);
            return context.SaveChanges();
        }

        public static int Modificar(Especialidad especialidad)
        {
            Especialidad especialidadOrigen = context.Especialidades.Find(especialidad.Id);
            if (especialidadOrigen != null)
                especialidadOrigen.Nombre = especialidad.Nombre;

            return context.SaveChanges();
        }

        public static int Eliminar(int id)
        {
            Especialidad especialidadOrigen = context.Especialidades.Find(id);
            if (especialidadOrigen != null)
                context.Especialidades.Remove(especialidadOrigen);

            return context.SaveChanges();
        }
    }
}
