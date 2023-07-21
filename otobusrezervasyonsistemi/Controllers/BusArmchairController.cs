using Microsoft.AspNetCore.Mvc;

namespace otobusrezervasyonsistemi.Controllers
{
    public class BusArmchairController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
