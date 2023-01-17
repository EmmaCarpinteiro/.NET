using exercicio2.Config;
using exercicio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace exercicio2.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly DBEmpresaContext _context;

            public EmpleadosController(DBEmpresaContext context)
        {
            _context= context;
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<Empleado>>> Get()
        {
           return await _context.empleados.ToListAsync();
        }

        [HttpPost("save")]
        public async Task<ActionResult> Post(Empleado empleado)
        {
            _context.Add(empleado);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}