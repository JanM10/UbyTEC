using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class Top10Pedidos
    {
        [Key]
        public int Cedula { get; set; }
        public int Id_pedido { get; set; }
        public int Afiliado { get; set; }
        public Double Monto_total { get; set; }
        public string? Feedback { get; set; }
    }
}
