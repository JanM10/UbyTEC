using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class AfiliadosController : ControllerBase
    {
        private readonly IMongoCollection<AfiliadosComercio> _afiliados;
        public AfiliadosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _afiliados = database.GetCollection<AfiliadosComercio>("Afiliados");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AfiliadosComercio>>> getAfiliados()
        {
            return await _afiliados.Find(Builders<AfiliadosComercio>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idAfiliado")]
        public async Task<ActionResult<AfiliadosComercio>> getAdiliadoId(int idAfiliado)
        {
            var filterDefinition = Builders<AfiliadosComercio>.Filter.Eq(x => x.Cedula_Juridica, idAfiliado);
            return await _afiliados.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addAfiliado(AfiliadosComercio newafiliado)
        {
            await _afiliados.InsertOneAsync(newafiliado);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarAfiliado(AfiliadosComercio newafiliado)
        {
            var filterDefinition = Builders<AfiliadosComercio>.Filter.Eq(x => x.Cedula_Juridica, newafiliado.Cedula_Juridica);
            await _afiliados.ReplaceOneAsync(filterDefinition, newafiliado);
            return Ok();
        }
        [HttpDelete("{idAfiliado")]
        public async Task<ActionResult> eliminarAdministrador(int idAfiliado)
        {
            var filterDefinition = Builders<AfiliadosComercio>.Filter.Eq(x => x.Cedula_Juridica, idAfiliado);
            await _afiliados.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
