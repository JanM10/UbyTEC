using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class Top10PedidosController : ControllerBase
    {
        private readonly IMongoCollection<Top10Pedidos> _top10;
        public Top10PedidosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _top10 = database.GetCollection<Top10Pedidos>("Top10Pedidos");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Top10Pedidos>>> getData()
        {
            return await _top10.Find(Builders<Top10Pedidos>.Filter.Empty).ToListAsync();
        }
    }
}
