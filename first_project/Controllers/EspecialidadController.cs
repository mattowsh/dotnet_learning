using Microsoft.AspNetCore.Mvc;

namespace first_project.Controllers
{
    public class EspecialidadController : Controller
    {
        // Constructor:
        public EspecialidadController()
        {
            
        }

        // Actions:
        public IActionResult Index()
        {
            return View();
        }
    }
}