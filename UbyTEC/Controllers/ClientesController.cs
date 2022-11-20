using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientesController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<Clientes>>> Get()
        {
            return Ok(await _context.Clientes.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_Cedula")]
        public async Task<ActionResult<List<Clientes>>> Get(int cedula)
        {
            var dbClientes = await _context.Clientes.FindAsync(cedula);
            if (dbClientes == null)
            {
                return BadRequest("Cliente no encontrado");
            }
            return Ok(dbClientes);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<Clientes>>> Post(Clientes clientes)
        {
            _context.Clientes.Add(clientes);
            await _context.SaveChangesAsync();
            return Ok(await _context.Clientes.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut("Edit")]
        public async Task<ActionResult<List<Clientes>>> Put(Clientes request)
        {
            var dbClientes = await _context.Clientes.FindAsync(request.Cedula);
            if (dbClientes == null)
            {
                return BadRequest("Cliente no encontrado");
            }

            dbClientes.Nombre = request.Nombre;
            dbClientes.Apellido1 = request.Apellido1;
            dbClientes.Apellido2 = request.Apellido2;
            dbClientes.Provincia = request.Provincia;
            dbClientes.Canton = request.Canton;
            dbClientes.Distrito = request.Distrito;
            dbClientes.Fecha_nacimiento = request.Fecha_nacimiento;
            dbClientes.Telefono = request.Telefono;
            dbClientes.Usuario = request.Usuario;
            dbClientes.Password = request.Password;

            await _context.SaveChangesAsync();

            return Ok(await _context.Clientes.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("Delete_Cedula")]
        public async Task<ActionResult<List<Clientes>>> Delete(int cedula)
        {
            var dbClientes = await _context.Clientes.FindAsync(cedula);
            if (dbClientes == null)
            {
                return BadRequest("Cliente no encontrado");
            }
            _context.Clientes.Remove(dbClientes);
            await _context.SaveChangesAsync();

            return Ok(await _context.Clientes.ToListAsync());
        }
    }
}
