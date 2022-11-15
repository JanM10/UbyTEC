using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Afiliados")]
    [ApiController]
    public class AfiliadosController : ControllerBase
    {
        private readonly DataContext _context;

        public AfiliadosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet]
        public async Task<ActionResult<List<Afiliados>>> Get()
        {
            return Ok(await _context.Afiliados.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("{Cedula_Juridica}")]
        public async Task<ActionResult<List<Afiliados>>> Get(int cedula_juridica)
        {
            var dbAfiliados = await _context.Afiliados.FindAsync(cedula_juridica);
            if (dbAfiliados == null)
            {
                return BadRequest("Afiliado no encontrado");
            }
            return Ok(dbAfiliados);
        }

        // POST: Se guardan los datos
        [HttpPost]
        public async Task<ActionResult<List<Afiliados>>> Post(Afiliados afiliado)
        {
            _context.Afiliados.Add(afiliado);
            await _context.SaveChangesAsync();
            return Ok(await _context.Afiliados.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut]
        public async Task<ActionResult<List<Afiliados>>> Put(Afiliados request)
        {
            var dbAfiliados = await _context.Afiliados.FindAsync(request.Cedula_Juridica);
            if (dbAfiliados == null)
            {
                return BadRequest("Afiliado no encontrado");
            }

            dbAfiliados.Nombre_Comercio = request.Nombre_Comercio;
            dbAfiliados.Tipo_Comercio = request.Tipo_Comercio;
            dbAfiliados.Provincia = request.Provincia;
            dbAfiliados.Canton = request.Canton;
            dbAfiliados.Distrito = request.Distrito;
            dbAfiliados.Telefono1 = request.Telefono1;
            dbAfiliados.Telefono2 = request.Telefono2;
            dbAfiliados.Correo = request.Correo;
            dbAfiliados.Sinpe = request.Sinpe;
            dbAfiliados.Administrador = request.Administrador;

            await _context.SaveChangesAsync();

            return Ok(await _context.Afiliados.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("{Cedula_Juridica}")]
        public async Task<ActionResult<List<Afiliados>>> Delete(int cedula_juridica)
        {
            var dbAfiliados = await _context.Afiliados.FindAsync(cedula_juridica);
            if (dbAfiliados == null)
            {
                return BadRequest("Afiliado no encontrado");
            }
            _context.Afiliados.Remove(dbAfiliados);
            await _context.SaveChangesAsync();

            return Ok(await _context.Afiliados.ToListAsync());
        }
    }
}
