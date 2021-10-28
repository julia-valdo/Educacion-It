using System.Data.Entity;
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbClinicaContext() : base("KeyClinica") { }

        //Propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}
