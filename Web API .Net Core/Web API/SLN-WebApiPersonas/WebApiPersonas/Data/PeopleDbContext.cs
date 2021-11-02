using Microsoft.EntityFrameworkCore;
using WebApiPersonas.Models;

namespace WebApiPersonas.Data
{
    public class PeopleDbContext : DbContext
    {
        // Tiene que estar el constructor con parametro:
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options) { }

        // DbSet:
        public DbSet<Person> People { get; set; }
    }
}
