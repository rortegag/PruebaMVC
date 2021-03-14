using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace PruebaTecnica.Context
{
    public class PersonasDBContext : DbContext
    {
        public PersonasDBContext(DbContextOptions<PersonasDBContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
