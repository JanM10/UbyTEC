using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IMongoCollection<Clientes> _clientes;
        public ClientesController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _clientes = database.GetCollection<Clientes>("Clientes");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> getData()
        {
            return await _clientes.Find(Builders<Clientes>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idcliente")]
        public async Task<ActionResult<Clientes>> getDataId(int idcliente)
        {
            var filterDefinition = Builders<Clientes>.Filter.Eq(x => x.Cedula, idcliente);
            return await _clientes.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(Clientes newcliente)
        {
            await _clientes.InsertOneAsync(newcliente);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(Clientes newcliente)
        {
            var filterDefinition = Builders<Clientes>.Filter.Eq(x => x.Cedula, newcliente.Cedula);
            await _clientes.ReplaceOneAsync(filterDefinition, newcliente);
            return Ok();
        }
        [HttpDelete("{idCliente")]
        public async Task<ActionResult> eliminardata(int idCliente)
        {
            var filterDefinition = Builders<Clientes>.Filter.Eq(x => x.Cedula, idCliente);
            await _clientes.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
