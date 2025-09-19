using Microsoft.AspNetCore.Mvc;

namespace BiggusTickus.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
