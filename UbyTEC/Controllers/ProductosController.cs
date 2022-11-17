using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbyTEC.Models;

namespace UbyTEC.Controllers
{
    [Route("api/Productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductosController(DataContext context)
        {
            _context = context;
        }

        // GET: Se muestran los datos obtenidos 
        [HttpGet]
        public async Task<ActionResult<List<Productos>>> Get()
        {
            return Ok(await _context.Productos.ToListAsync());
        }

        // GET: Se muestran los datos obtenidos por ID 
        [HttpGet("{Id_Producto}")]
        public async Task<ActionResult<List<Productos>>> Get(int id_producto)
        {
            var dbProductos = await _context.Productos.FindAsync(id_producto);
            if (dbProductos == null)
            {
                return BadRequest("Producto no encontrado");
            }
            return Ok(dbProductos);
        }

        // POST: Se guardan los datos
        [HttpPost]
        public async Task<ActionResult<List<Productos>>> Post(Productos id_producto)
        {
            _context.Productos.Add(id_producto);
            await _context.SaveChangesAsync();
            return Ok(await _context.Productos.ToListAsync());
        }

        // PUT: Se actualiza los datos
        [HttpPut]
        public async Task<ActionResult<List<Productos>>> Put(Productos request)
        {
            var dbProductos = await _context.Productos.FindAsync(request.Id_Producto);
            if (dbProductos == null)
            {
                return BadRequest("Producto no encontrado");
            }

            dbProductos.Nombre_Producto = request.Nombre_Producto;
            dbProductos.Categoria = request.Categoria;
            dbProductos.Precio = request.Precio;
            dbProductos.Fotos = request.Fotos; //COMO SE AGREGAN FOTOS??

            await _context.SaveChangesAsync();

            return Ok(await _context.Productos.ToListAsync());
        }

        // DELETE: se elimina un dato
        [HttpDelete("{Id_Producto}")]
        public async Task<ActionResult<List<Productos>>> Delete(int id_producto)
        {
            var dbProductos = await _context.Productos.FindAsync(id_producto);
            if (dbProductos == null)
            {
                return BadRequest("Producto no encontrado");
            }
            _context.Productos.Remove(dbProductos);
            await _context.SaveChangesAsync();

            return Ok(await _context.Productos.ToListAsync());
        }
    }
}
