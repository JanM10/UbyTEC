using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class TiposComercioController : ControllerBase
    {
        private readonly IMongoCollection<TiposComercio> _tiposComercio;
        public TiposComercioController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _tiposComercio = database.GetCollection<TiposComercio>("TiposComercio");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposComercio>>> getData()
        {
            return await _tiposComercio.Find(Builders<TiposComercio>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idtipocomercio")]
        public async Task<ActionResult<TiposComercio>> getDataId(int idtipocomercio)
        {
            var filterDefinition = Builders<TiposComercio>.Filter.Eq(x => x.Id_Comercio, idtipocomercio);
            return await _tiposComercio.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(TiposComercio newobject)
        {
            await _tiposComercio.InsertOneAsync(newobject);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(TiposComercio newobject)
        {
            var filterDefinition = Builders<TiposComercio>.Filter.Eq(x => x.Id_Comercio, newobject.Id_Comercio);
            await _tiposComercio.ReplaceOneAsync(filterDefinition, newobject);
            return Ok();
        }
        [HttpDelete("{idtipocomercio")]
        public async Task<ActionResult> eliminarData(int idtipocomercio)
        {
            var filterDefinition = Builders<TiposComercio>.Filter.Eq(x => x.Id_Comercio, idtipocomercio);
            await _tiposComercio.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
