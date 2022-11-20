using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Empleados")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly DataContext _context;

        public EmpleadosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet("Get")]
        public async Task<ActionResult<List<Empleados>>> Get()
        {
            return Ok(await _context.Empleados.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("Get_Cedula")]
        public async Task<ActionResult<List<Empleados>>> Get(int cedula)
        {
            var dbEmpleados = await _context.Empleados.FindAsync(cedula);
            if (dbEmpleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }
            return Ok(dbEmpleados);
        }

        // POST: Se guardan los datos
        [HttpPost("Post")]
        public async Task<ActionResult<List<Empleados>>> Post(Empleados empleados)
        {
            _context.Empleados.Add(empleados);
            await _context.SaveChangesAsync();
            return Ok(await _context.Empleados.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut("Edit")]
        public async Task<ActionResult<List<Empleados>>> Put(Empleados request)
        {
            var dbEmpleados = await _context.Empleados.FindAsync(request.Cedula);
            if (dbEmpleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }

            dbEmpleados.Nombre = request.Nombre;
            dbEmpleados.Apellido1 = request.Apellido1;
            dbEmpleados.Apellido2 = request.Apellido2;
            dbEmpleados.Provincia = request.Provincia;
            dbEmpleados.Canton = request.Canton;
            dbEmpleados.Distrito = request.Distrito;
            dbEmpleados.Telefono1 = request.Telefono1;
            dbEmpleados.Telefono2 = request.Telefono2;
            dbEmpleados.Usuario = request.Usuario;
            dbEmpleados.Password = request.Password;

            await _context.SaveChangesAsync();

            return Ok(await _context.Empleados.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("Delete_Cedula")]
        public async Task<ActionResult<List<Empleados>>> Delete(int cedula)
        {
            var dbEmpleados = await _context.Empleados.FindAsync(cedula);
            if (dbEmpleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }
            _context.Empleados.Remove(dbEmpleados);
            await _context.SaveChangesAsync();  

            return Ok(await _context.Empleados.ToListAsync());
        }
    }
}
