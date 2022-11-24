using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Tipos_Comercio")]
    [ApiController]
    public class TiposComercioController : ControllerBase
    {
        private readonly DataContext _context;

        public TiposComercioController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<TiposComercio>>> Get()
        {
            return Ok(await _context.TiposComercio.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_Id_Comercio")]
        public async Task<ActionResult<List<TiposComercio>>> Get(int id_comercio)
        {
            var dbTipoComercio = await _context.TiposComercio.FindAsync(id_comercio);
            if (dbTipoComercio == null)
            {
                return BadRequest("Comercio no encontrado");
            }
            return Ok(dbTipoComercio);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<TiposComercio>>> Post(TiposComercio tipoComercio)
        {
            _context.TiposComercio.Add(tipoComercio);
            await _context.SaveChangesAsync();
            return Ok(await _context.TiposComercio.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut("Edit")]
        public async Task<ActionResult<List<TiposComercio>>> Put(TiposComercio request)
        {
            var dbTipoComercio = await _context.TiposComercio.FindAsync(request.Id_Comercio);
            if (dbTipoComercio == null)
            {
                return BadRequest("Comercio no encontrado");
            }

            dbTipoComercio.Nombre_Comercio = request.Nombre_Comercio;

            await _context.SaveChangesAsync();

            return Ok(await _context.TiposComercio.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("Delete")]
        public async Task<ActionResult<List<TiposComercio>>> Delete(TiposComercio request)
        {
            var dbTipoComercio = await _context.TiposComercio.FindAsync(request.Id_Comercio);
            if (dbTipoComercio == null)
            {
                return BadRequest("Comercio no encontrado");
            }
            _context.TiposComercio.Remove(dbTipoComercio);
            await _context.SaveChangesAsync();

            return Ok(await _context.TiposComercio.ToListAsync());
        }
    }
}
