using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class TiposComercio
    {
        [Key]
        public int Id_Comercio { get; set; }
        public string Nombre_Comercio { get; set; }
        public string Tipo_Comercio { get; set; }
    }
}
