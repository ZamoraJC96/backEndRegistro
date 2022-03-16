//Contexto
using Microsoft.EntityFrameworkCore;

namespace backEndRegistro.Data
{
    public class DataContext : DbContext
    {
        //Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    }
}
