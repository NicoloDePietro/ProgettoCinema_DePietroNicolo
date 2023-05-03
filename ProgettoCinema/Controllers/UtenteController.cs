using Microsoft.AspNetCore.Mvc;

namespace ProgettoCinema.Controllers
{
    public class UtenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
