using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IMongoCollection<Pedidos> _pedido;
        public PedidosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _pedido = database.GetCollection<Pedidos>("Pedidos");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedidos>>> getData()
        {
            return await _pedido.Find(Builders<Pedidos>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idpedido")]
        public async Task<ActionResult<Pedidos>> getDataId(int idpedido)
        {
            var filterDefinition = Builders<Pedidos>.Filter.Eq(x => x.Id_pedido, idpedido);
            return await _pedido.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(Pedidos newpedido)
        {
            await _pedido.InsertOneAsync(newpedido);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(Pedidos newpedido)
        {
            var filterDefinition = Builders<Pedidos>.Filter.Eq(x => x.Id_pedido, newpedido.Id_pedido);
            await _pedido.ReplaceOneAsync(filterDefinition, newpedido);
            return Ok();
        }
        [HttpDelete("{idpedido")]
        public async Task<ActionResult> eliminarData(int idpedido)
        {
            var filterDefinition = Builders<Pedidos>.Filter.Eq(x => x.Id_pedido, idpedido);
            await _pedido.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
