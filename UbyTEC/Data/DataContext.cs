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

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<AdministradorComercio> AdministradorComercio { get; set; }

        public DbSet<Pedidos> Pedidos { get; set; }

        public DbSet<ReportesAfiliados> Vista_ReporteVentasAfiliado { get; set; }

        public DbSet<ReportesClientes> Vista_ReporteVentasCliente { get; set; }

        public DbSet<Top10Pedidos> Vista_UltimasVentasPorUsuario { get; set; }
    }
}
