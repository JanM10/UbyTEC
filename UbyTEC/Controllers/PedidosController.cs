using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Pedidos")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly DataContext _context;

        public PedidosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<Pedidos>>> Get()
        {
            return Ok(await _context.Pedidos.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_id_pedido")]
        public async Task<ActionResult<List<Pedidos>>> Get(int id_pedido)
        {
            var dbPedidos = await _context.Pedidos.FindAsync(id_pedido);
            if (dbPedidos == null)
            {
                return BadRequest("Pedido no encontrado");
            }
            return Ok(dbPedidos);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<Pedidos>>> Post(Pedidos pedidos)
        {
            _context.Pedidos.Add(pedidos);
            await _context.SaveChangesAsync();
            return Ok(await _context.Pedidos.ToListAsync());
        }

        // PUT: Se realiza el pedido
        [HttpPut]
        public async Task<ActionResult<List<Pedidos>>> Put(Pedidos request)
        {
            var dbPedidos = await _context.Pedidos.FindAsync(request.Id_pedido);
            if (dbPedidos == null)
            {
                return BadRequest("Pedido no encontrado");
            }

            //_context.Pedidos.($"CALL public.\"AsignarPedidos\"({request.Afiliado})");

            // Connect to a PostgreSQL database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Database=UbyTEC;" +
                "Port=5432;User Id=postgres;Password=PostgreSQL123;");
            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand($"CALL \"AsignarPedidos\"({request.Afiliado})", conn);
            command.ExecuteReader();

            await Task.Delay(20000).ContinueWith(async (task) =>
            {
                request.Estado = "Entregado";

                await _context.SaveChangesAsync();
            });

            return Ok(await _context.Pedidos.ToListAsync());
        }
    }
}
