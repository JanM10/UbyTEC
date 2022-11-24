using MongoDB.Bson.Serialization.Attributes;

namespace UbyTECMonGO.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class ReportesCliente
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Cliente { get; set; }
        [BsonElement("_afiliado"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Afiliado { get; set; }
        [BsonElement("_repartidor"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Repartidor { get; set; }
        [BsonElement("_compras"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Compras { get; set; }
        [BsonElement("_montoTotal"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public Double Monto_Total { get; set; }
        [BsonElement("_montoServicio"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public Double Monto_Servicio { get; set; }
    }
}
