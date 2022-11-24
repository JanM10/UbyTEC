using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Productos
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id_Producto { get; set; }
        [BsonElement("_nombreProducto"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Nombre_Producto { get; set; } = string.Empty;
        [BsonElement("_categoria"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Categoria { get; set; } = string.Empty;
        [BsonElement("_precio"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Precio { get; set; }
        [BsonElement("_fotos"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Fotos { get; set; } = string.Empty;
        [BsonElement("_idAfiliado"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Id_Afiliado { get; set; }
    }
}
