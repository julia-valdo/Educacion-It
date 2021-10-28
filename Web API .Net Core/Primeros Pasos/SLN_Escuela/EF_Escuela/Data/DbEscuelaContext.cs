using EF_Escuela.Models;
using System.Data.Entity;

namespace EF_Ventas.Data
{
    public class DbEscuelaContext : DbContext
    {
        public DbEscuelaContext() : base("KeyEscuela") { }

        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Detalle> Dettalle { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Evaluacion> Evaluacion { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Planilla> Planilla { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
    }
}
