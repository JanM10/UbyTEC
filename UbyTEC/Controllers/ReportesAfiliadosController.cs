using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/ReportesAfiliados")]
    [ApiController]
    public class ReportesAfiliadosController : ControllerBase
    {
        private readonly DataContext _context;

        public ReportesAfiliadosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<ReportesAfiliados>>> Get()
        {
            return Ok(await _context.ReportesAfiliados.ToListAsync());
        }
    }
}
