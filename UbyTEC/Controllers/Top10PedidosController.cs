using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Top10Pedidos")]
    [ApiController]
    public class Top10PedidosController : ControllerBase
    {
        private readonly DataContext _context;

        public Top10PedidosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<Top10Pedidos>>> Get()
        {
            return Ok(await _context.Vista_UltimasVentasPorUsuario.ToListAsync());
        }

/*    // GET: Se muestran los datos obtenidos por ID 
    [HttpGet("Get_Cedula")]
    public async Task<ActionResult<List<Top10Pedidos>>> Get(int cedula)
    {
        var dbEmpleados = await _context.Vista_UltimasVentasPorUsuario.FindAsync(cedula);

        // Connect to a PostgreSQL database
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Database=UbyTEC;" +
            "Port=5432;User Id=postgres;Password=PostgreSQL123;");
        conn.Open();

        // Define a query returning a single row result set
        NpgsqlCommand command = new NpgsqlCommand($"CALL \"Top10Pedidos\"({cedula})", conn);
        command.ExecuteReader();

        if (dbEmpleados == null)
        {
            return BadRequest("Vista no encontrada");
        }
        return Ok(dbEmpleados);
    }*/
    }
}
