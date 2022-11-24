using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IMongoCollection<Productos> _producto;
        public ProductosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _producto = database.GetCollection<Productos>("Productos");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> getData()
        {
            return await _producto.Find(Builders<Productos>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idproducto")]
        public async Task<ActionResult<Productos>> getDataId(int idproducto)
        {
            var filterDefinition = Builders<Productos>.Filter.Eq(x => x.Id_Producto, idproducto);
            return await _producto.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(Productos newproducto)
        {
            await _producto.InsertOneAsync(newproducto);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(Productos newproducto)
        {
            var filterDefinition = Builders<Productos>.Filter.Eq(x => x.Id_Producto, newproducto.Id_Producto);
            await _producto.ReplaceOneAsync(filterDefinition, newproducto);
            return Ok();
        }
        [HttpDelete("{idproducto")]
        public async Task<ActionResult> eliminarData(int idproducto)
        {
            var filterDefinition = Builders<Productos>.Filter.Eq(x => x.Id_Producto, idproducto);
            await _producto.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
