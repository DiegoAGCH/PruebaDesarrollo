using Microsoft.AspNetCore.Mvc;
using PruebaDesarrollo.Data;
using PruebaDesarrollo.Models;
using Microsoft.EntityFrameworkCore;

namespace PruebaDesarrollo.Controllers
{
    public class UsuariosController : ControllerBase
    {
        private readonly AppDBContext _context;

        public UsuariosController(AppDBContext context) {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            var user = await _context.Usuarios.ToListAsync();
            return Ok(user);

        }
        [HttpGet ("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            return Ok(user);

        }

        [HttpPost]
        public async Task<IActionResult> PostUser(Usuario us)
        {
            _context.Usuarios.Add(us);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult>PutUser(int id, Usuario us)
        {
            if (id != us.UserId)
            {
                return BadRequest();
            }
            _context.Entry(us);
            await _context.SaveChangesAsync();
            return Ok(us);
        }
    }
}
