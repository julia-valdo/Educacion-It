using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;

namespace WebApiEscuela.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
