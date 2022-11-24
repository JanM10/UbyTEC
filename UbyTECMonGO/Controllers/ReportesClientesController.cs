using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class ReportesClientesController : ControllerBase
    {
        private readonly IMongoCollection<ReportesCliente> _reportesC;
        public ReportesClientesController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _reportesC = database.GetCollection<ReportesCliente>("ReportesClientes");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportesCliente>>> getData()
        {
            return await _reportesC.Find(Builders<ReportesCliente>.Filter.Empty).ToListAsync();
        }
    }
}
