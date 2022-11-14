using Microsoft.EntityFrameworkCore;
using UbyTEC.Models;

namespace UbyTEC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Empleados> Empleados { get; set; }
    }
}
