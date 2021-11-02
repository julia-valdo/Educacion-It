using Microsoft.EntityFrameworkCore;
using SWMedicos.Models;

namespace SWMedicos.Data
{
    public class MedicosDbContext : DbContext
    {
        public MedicosDbContext(DbContextOptions<MedicosDbContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
    }
}
