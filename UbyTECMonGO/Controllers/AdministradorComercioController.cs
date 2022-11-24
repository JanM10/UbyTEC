using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/AdministradorComercio")]
    [ApiController]
    public class AdministradorComercioController : ControllerBase
    {
        private readonly IMongoCollection<AdministradorComercio> _administradorComercio;
        public AdministradorComercioController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString) ;
            var mongoCliente = new MongoClient(mongoURL) ;
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _administradorComercio = database.GetCollection<AdministradorComercio>("AdministradorComercio");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdministradorComercio>>> getAdministrador()
        {
            return await _administradorComercio.Find(Builders<AdministradorComercio>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idAdministrador")]
        public async Task<ActionResult<AdministradorComercio>> getAdministradorId(int idAdministrador)
        {
            var filterDefinition = Builders<AdministradorComercio>.Filter.Eq(x => x.Id_Admin, idAdministrador);
            return await _administradorComercio.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addAdministrador(AdministradorComercio newadmin)
        {
            await _administradorComercio.InsertOneAsync(newadmin);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarAdministrador(AdministradorComercio newadmin)
        {
            var filterDefinition = Builders<AdministradorComercio>.Filter.Eq(x => x.Id_Admin, newadmin.Id_Admin);
            await _administradorComercio.ReplaceOneAsync(filterDefinition, newadmin);
            return Ok();
        }
        [HttpDelete("{idAdministrador")]
        public async Task<ActionResult> eliminarAdministrador(int idAdministrador)
        {
            var filterDefinition = Builders<AdministradorComercio>.Filter.Eq(x => x.Id_Admin, idAdministrador);
            await _administradorComercio.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
