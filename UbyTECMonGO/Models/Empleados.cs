using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Empleados
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Cedula { get; set; }
        [BsonElement("_nombre"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Nombre { get; set; } = string.Empty;
        [BsonElement("_apellido1"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Apellido1 { get; set; } = string.Empty;
        [BsonElement("_apellido2"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Apellido2 { get; set; } = string.Empty;
        [BsonElement("_provincia"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Provincia { get; set; } = string.Empty;
        [BsonElement("_canton"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Canton { get; set; } = string.Empty;
        [BsonElement("_distrito"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Distrito { get; set; } = string.Empty;
        [BsonElement("_telefono1"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Telefono1 { get; set; }
        [BsonElement("_telefono2"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Telefono2 { get; set; }
        [BsonElement("_usuario"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Usuario { get; set; } = string.Empty;
         [BsonElement("_password"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Password { get; set; } = string.Empty;
   
    }
}
