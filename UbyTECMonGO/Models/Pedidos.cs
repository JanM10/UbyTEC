using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Pedidos
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id_pedido { get; set; }
        [BsonElement("_cliente"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Cliente { get; set; }
        [BsonElement("_afiliado"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Afiliado { get; set; }
        [BsonElement("_repartidor"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int? Repartidor { get; set; }
        [BsonElement("_montoTotal"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public Double Monto_total { get; set; }
        [BsonElement("_montoServicio"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public Double Monto_servicio { get; set; }
        [BsonElement("_Estado"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? Estado { get; set; }
        [BsonElement("_feedback"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? Feedback { get; set; }
    }
}
