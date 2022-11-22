using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class ReportesClientes
    {
        [Key]
        public string Cliente { get; set; }
        public string Afiliado { get; set; }
        public string Repartidor { get; set; }
        public int Compras { get; set; }
        public Double Monto_Total { get; set; }
        public Double Monto_Servicio { get; set; }
    }
}
