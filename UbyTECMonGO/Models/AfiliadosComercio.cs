using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class AfiliadosComercio
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Cedula_Juridica { get; set; }
        [BsonElement("_nombreComercio"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Nombre_Comercio { get; set; } = string.Empty;
        [BsonElement("_tipoComercio"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Tipo_Comercio { get; set; }
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
        [BsonElement("_correo"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Correo { get; set; } = string.Empty;
        [BsonElement("_sinpe"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Sinpe { get; set; }
        [BsonElement("_administrador"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Administrador { get; set; } //Es int pq se conecta con id_admin con la tabla AdminComercio
        [BsonElement("_estado"), BsonRepresentation(MongoDB.Bson.BsonType.Boolean)]
        public bool Estado { get; set; }
        [BsonElement("_comentario"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Comentario { get; set; } = string.Empty;
    }
}
