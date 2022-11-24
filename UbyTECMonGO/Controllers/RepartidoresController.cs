using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class RepartidoresController : ControllerBase
    {
        private readonly IMongoCollection<Repartidores> _repartidores;
        public RepartidoresController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _repartidores = database.GetCollection<Repartidores>("Repartidores");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Repartidores>>> getData()
        {
            return await _repartidores.Find(Builders<Repartidores>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idrepartidor")]
        public async Task<ActionResult<Repartidores>> getDataId(int idrepartidor)
        {
            var filterDefinition = Builders<Repartidores>.Filter.Eq(x => x.idRepartidor, idrepartidor);
            return await _repartidores.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(Repartidores newobject)
        {
            await _repartidores.InsertOneAsync(newobject);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(Repartidores newobject)
        {
            var filterDefinition = Builders<Repartidores>.Filter.Eq(x => x.idRepartidor, newobject.idRepartidor);
            await _repartidores.ReplaceOneAsync(filterDefinition, newobject);
            return Ok();
        }
        [HttpDelete("{idrepartidor")]
        public async Task<ActionResult> eliminarData(int idrepartidor)
        {
            var filterDefinition = Builders<Repartidores>.Filter.Eq(x => x.idRepartidor, idrepartidor);
            await _repartidores.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
