using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
