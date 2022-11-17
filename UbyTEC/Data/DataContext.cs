using Microsoft.EntityFrameworkCore;
using UbyTEC.Models;

namespace UbyTEC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Empleados> Empleados { get; set; }

        public DbSet<Afiliados> Afiliados { get; set; }

        public DbSet<TiposComercio> TiposComercio { get; set; }

        public DbSet<Repartidores> Repartidores { get; set; }

        public DbSet<Productos> Productos { get; set; }
    }
}
