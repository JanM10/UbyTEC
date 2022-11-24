using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Top10Pedidos
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Cedula { get; set; }
        [BsonElement("_idPedido"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Id_pedido { get; set; }
        [BsonElement("_afiliado"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Afiliado { get; set; }
        [BsonElement("_montoTotal"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public Double Monto_total { get; set; }
        [BsonElement("_feedback"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? Feedback { get; set; }

    }
}
