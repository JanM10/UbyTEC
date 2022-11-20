using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class Empleados
    {
        [Key]
        public int Cedula { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido1 { get; set; } = string.Empty;
        public string Apellido2 { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Canton { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
