using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class Pedidos
    {
        [Key]
        public int Id_pedido { get; set; }
        public int Cliente { get; set; }
        public int Afiliado { get; set; }
        public int? Repartidor { get; set; }
        public Double Monto_total { get; set; }
        public Double Monto_servicio { get; set; }
        public string? Estado { get; set; }
        public string? Feedback { get; set; }
    }
}
