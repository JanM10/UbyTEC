using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class TiposComercio
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id_Comercio { get; set; }
        [BsonElement("_nombreComercio"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Nombre_Comercio { get; set; } = string.Empty;
    }
}
