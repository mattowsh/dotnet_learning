using Microsoft.AspNetCore.Mvc;
using first_project.Models;
using System.Linq;

namespace first_project.Controllers
{
    public class EspecialidadController : Controller
    {

        // We need an object to intializate in our constructor. Thus, we will
        // create this object called _context, of type first_projectContext:
        private readonly first_projectContext _context;

        // Constructor:
        // Constructor receive an object called "context", of type first_projectContext
        public EspecialidadController(first_projectContext context)
        {
            _context = context;
        }

        // Actions:
        public IActionResult Index()
        {
            return View(_context.Especialidad.ToList());
        }
    }
}