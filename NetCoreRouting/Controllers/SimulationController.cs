using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
