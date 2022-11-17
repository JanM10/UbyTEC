using System.ComponentModel.DataAnnotations;

namespace UbyTEC.Models
{
    public class Productos
    {
        [Key]
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int Precio { get; set; }
        public string Fotos { get; set; } = string.Empty; //COMO SE AGREGAN FOTOS??
    }
}
