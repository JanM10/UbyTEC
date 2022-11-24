using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/AdministradorComercio")]
    [ApiController]
    public class AdminComercioController : ControllerBase
    {
        private readonly DataContext _context;

        public AdminComercioController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<AdministradorComercio>>> Get()
        {
            return Ok(await _context.AdministradorComercio.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_Id_Admin")]
        public async Task<ActionResult<List<AdministradorComercio>>> Get(int id_admin)
        {
            var dbAdminComercio = await _context.AdministradorComercio.FindAsync(id_admin);
            if (dbAdminComercio == null)
            {
                return BadRequest("Administrador no encontrado");
            }
            return Ok(dbAdminComercio);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<AdministradorComercio>>> Post(AdministradorComercio empleados)
        {
            _context.AdministradorComercio.Add(empleados);
            await _context.SaveChangesAsync();
            return Ok(await _context.AdministradorComercio.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut("Edit")]
        public async Task<ActionResult<List<AdministradorComercio>>> Put(AdministradorComercio request)
        {
            var dbAdminComercio = await _context.AdministradorComercio.FindAsync(request.Id_Admin);
            if (dbAdminComercio == null)
            {
                return BadRequest("Administrador no encontrado");
            }

            dbAdminComercio.Nombre = request.Nombre;
            dbAdminComercio.Apellido1 = request.Apellido1;
            dbAdminComercio.Apellido2 = request.Apellido2;
            dbAdminComercio.Provincia = request.Provincia;
            dbAdminComercio.Canton = request.Canton;
            dbAdminComercio.Distrito = request.Distrito;
            dbAdminComercio.Telefono1 = request.Telefono1;
            dbAdminComercio.Telefono2 = request.Telefono2;
            dbAdminComercio.Correo = request.Correo;
            dbAdminComercio.Usuario = request.Usuario;
            dbAdminComercio.Password = request.Password;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.AdministradorComercio.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("Delete")]
        public async Task<ActionResult<List<AdministradorComercio>>> Delete(AdministradorComercio request)
        {
            var dbAdminComercio = await _context.AdministradorComercio.FindAsync(request.Id_Admin);
            if (dbAdminComercio == null)
            {
                return BadRequest("Administrador no encontrado");
            }
            _context.AdministradorComercio.Remove(dbAdminComercio);
            await _context.SaveChangesAsync();

            return Ok(await _context.AdministradorComercio.ToListAsync());
        }
    }
}
