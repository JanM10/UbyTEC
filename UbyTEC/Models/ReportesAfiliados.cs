using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class ReportesAfiliados
    {
        [Key]
        public string Afiliado { get; set; }
        public int Compras { get; set; }
        public Double Monto_Total { get; set; }
        public Double Monto_Servicio { get; set; }
    }
}
