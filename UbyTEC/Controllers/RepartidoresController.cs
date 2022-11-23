using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Repartidores")]
    [ApiController]
    public class RepartidoresController : ControllerBase
    {
        private readonly DataContext _context;

        public RepartidoresController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<Repartidores>>> Get()
        {
            return Ok(await _context.Repartidores.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_idRepartidor")]
        public async Task<ActionResult<List<Repartidores>>> Get(int idRepartidor)
        {
            var dbRepartidores = await _context.Repartidores.FindAsync(idRepartidor);
            if (dbRepartidores == null)
            {
                return BadRequest("Repartidor no encontrado");
            }
            return Ok(dbRepartidores);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<Repartidores>>> Post(Repartidores repartidores)
        {
            _context.Repartidores.Add(repartidores);
            await _context.SaveChangesAsync();
            return Ok(await _context.Repartidores.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut("Edit")]
        public async Task<ActionResult<List<Repartidores>>> Put(Repartidores request)
        {
            var dbRepartidores = await _context.Repartidores.FindAsync(request.idRepartidor);
            if (dbRepartidores == null)
            {
                return BadRequest("Repartidor no encontrado");
            }

            dbRepartidores.Nombre = request.Nombre;
            dbRepartidores.Apellido1 = request.Apellido1;
            dbRepartidores.Apellido2 = request.Apellido2;
            dbRepartidores.Provincia = request.Provincia;
            dbRepartidores.Canton = request.Canton;
            dbRepartidores.Distrito = request.Distrito;
            dbRepartidores.Telefono1 = request.Telefono1;
            dbRepartidores.Telefono2 = request.Telefono2;
            dbRepartidores.Correo = request.Correo;
            dbRepartidores.Usuario = request.Usuario;
            dbRepartidores.Password = request.Password;
            dbRepartidores.Estado = request.Estado;

            await _context.SaveChangesAsync();

            return Ok(await _context.Repartidores.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("Delete")]
        public async Task<ActionResult<List<Repartidores>>> Delete(int idRepartidor)
        {
            var dbRepartidores = await _context.Repartidores.FindAsync(idRepartidor);
            if (dbRepartidores == null)
            {
                return BadRequest("Repartidor no encontrado");
            }
            _context.Repartidores.Remove(dbRepartidores);
            await _context.SaveChangesAsync();

            return Ok(await _context.Repartidores.ToListAsync());
        }

/*        //---------------------------------------
        [HttpPut("TiempoOrden")]
        public async Task<ActionResult<List<Repartidores>>> TiempoOrden(Repartidores request)
        {
            var dbRepartidores = await _context.Repartidores.FindAsync(request.idRepartidor);
            if (dbRepartidores == null)
            {
                return BadRequest("Repartidor no encontrado");
            }

            dbRepartidores.Estado = "No disponible";

            await _context.SaveChangesAsync();

            await State(request);

            return Ok(await _context.Repartidores.ToListAsync());
        }

        [HttpPut("State")]
        public async Task<ActionResult<List<Repartidores>>> State(Repartidores request)
        {
            var dbRepartidores = await _context.Repartidores.FindAsync(request.idRepartidor);
            await Task.Delay(20000).ContinueWith(async (task) =>
            {
                dbRepartidores.Estado = "Disponible";


                await _context.SaveChangesAsync();
            });

            return Ok(await _context.Repartidores.ToListAsync());
        }*/
    }
}
