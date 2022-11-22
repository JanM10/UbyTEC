using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/ReportesClientes")]
    [ApiController]
    public class ReportesClientesController : ControllerBase
    {
        private readonly DataContext _context;

        public ReportesClientesController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<ReportesClientes>>> Get()
        {
            return Ok(await _context.Vista_ReporteVentasCliente.ToListAsync());
        }
    }
}
