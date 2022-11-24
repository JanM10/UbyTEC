using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IMongoCollection<Empleados> _empleados;
        public EmpleadosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _empleados = database.GetCollection<Empleados>("Empleados");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> getData()
        {
            return await _empleados.Find(Builders<Empleados>.Filter.Empty).ToListAsync();
        }
        [HttpGet("{idempleado")]
        public async Task<ActionResult<Empleados>> getDataId(int idempleado)
        {
            var filterDefinition = Builders<Empleados>.Filter.Eq(x => x.Cedula, idempleado);
            return await _empleados.Find(filterDefinition).SingleOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult> addData(Empleados newempleado)
        {
            await _empleados.InsertOneAsync(newempleado);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> actualizarData(Empleados newempleado)
        {
            var filterDefinition = Builders<Empleados>.Filter.Eq(x => x.Cedula, newempleado.Cedula);
            await _empleados.ReplaceOneAsync(filterDefinition, newempleado);
            return Ok();
        }
        [HttpDelete("{idempleado")]
        public async Task<ActionResult> eliminardata(int idempleado)
        {
            var filterDefinition = Builders<Empleados>.Filter.Eq(x => x.Cedula, idempleado);
            await _empleados.DeleteOneAsync(filterDefinition);
            return Ok();
        }
    }
}
