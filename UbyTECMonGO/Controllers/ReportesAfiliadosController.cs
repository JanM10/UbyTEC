using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using UbyTECMonGO.Models;

namespace UbyTECMonGO.Controllers
{
    [Route("mongo/[controller]")]
    [ApiController]
    public class ReportesAfiliadosController : ControllerBase
    {
        private readonly IMongoCollection<ReportesAfiliados> _reportesA;
        public ReportesAfiliadosController()
        {
            var connectionString = $"mongodb + srv://ManuelJ:<5535manu5535>@cluster0.zi31op8.mongodb.net/?retryWrites=true&w=majority";
            var mongoURL = MongoUrl.Create(connectionString);
            var mongoCliente = new MongoClient(mongoURL);
            var database = mongoCliente.GetDatabase(mongoURL.DatabaseName);
            _reportesA = database.GetCollection<ReportesAfiliados>("ReportesAfiliados");
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportesAfiliados>>> getData()
        {
            return await _reportesA.Find(Builders<ReportesAfiliados>.Filter.Empty).ToListAsync();
        }
        
    }
}
