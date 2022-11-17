using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class Afiliados
    {
        [Key]
        public int Cedula_Juridica { get; set; }
        public string Nombre_Comercio { get; set; } = string.Empty;
        public string Tipo_Comercio { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Canton { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Correo { get; set; } = string.Empty;
        public int Sinpe { get; set; }
        public int Administrador { get; set; } //Es int pq se conecta con id_admin con la tabla AdminComercio
    }
}
