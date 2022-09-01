using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tareas.Models;

namespace Tareas.Controllers
{
    public class TareasController : Controller
    {
        private readonly TareasContext _context;

        public TareasController(TareasContext context){
            _context = context; 
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.ListaTareas.ToListAsync());
        }
    }
}
