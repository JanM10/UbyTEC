using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UbyTEC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private static List<Empleados>  LEmpleado = new List<Empleados>
            {
                new Empleados {Id = 1,
                Cedula = 123456789,
                Nombre = "Juan",
                Apellido1 = "Juan",
                Apellido2 = "Juan",
                Provincia = "San jose",
                Canton = "San jose",
                Distrito = "San jose",
                Telefono1 = 22222222,
                Telefono2 = 33333333,
                Usuario = "Juan123",
                Password = "123Juan"
                },
                new Empleados {Id = 2,
                Cedula = 987654321,
                Nombre = "Jose",
                Apellido1 = "Jose",
                Apellido2 = "Jose",
                Provincia = "San jose",
                Canton = "San jose",
                Distrito = "San jose",
                Telefono1 = 44444444,
                Telefono2 = 33333333,
                Usuario = "Jose123",
                Password = "123Jose"
                }
            };
        private readonly DataContext _context;

        public EmpleadosController(DataContext context)
        {
            this._context = context;
        }

        // GET: api/<EmpleadosController>
        [HttpGet]
        public async Task<ActionResult<List<Empleados>>> Get()
        {

            return Ok(await _context.Empleados.ToListAsync());
        }

        // GET: api/<EmpleadosController>
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Empleados>>> Get(int id)
        {
            var empleados = LEmpleado.Find(h => h.Id == id);
            if (empleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }
            return Ok(empleados);
        }

        // POST api/<EmpleadosController>
        [HttpPost]
        public async Task<ActionResult<List<Empleados>>> Post(Empleados empleados)
        {
            LEmpleado.Add(empleados);
            return Ok(LEmpleado);
        }

        // PUT api/<EmpleadosController>/5
        [HttpPut]
        public async Task<ActionResult<List<Empleados>>> Put(Empleados request)
        {
            var empleados = LEmpleado.Find(h => h.Id == request.Id);
            if (empleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }

            empleados.Cedula = request.Cedula;
            empleados.Nombre = request.Nombre;
            empleados.Apellido1 = request.Apellido1;
            empleados.Apellido2 = request.Apellido2;
            empleados.Provincia = request.Provincia;
            empleados.Canton = request.Canton;
            empleados.Distrito = request.Distrito;
            empleados.Telefono1 = request.Telefono1;
            empleados.Telefono2 = request.Telefono2;
            empleados.Usuario = request.Usuario;
            empleados.Password = request.Password;

            return Ok(LEmpleado);
        }

        // DELETE api/<EmpleadosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Empleados>>> Delete(int id)
        {
            var empleados = LEmpleado.Find(h => h.Id == id);
            if (empleados == null)
            {
                return BadRequest("Empleado no encontrado");
            }
            LEmpleado.Remove(empleados);
            return Ok(LEmpleado);
        }
    }
}
