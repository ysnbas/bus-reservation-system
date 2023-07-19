using Microsoft.AspNetCore.Mvc;

namespace otobusrezervasyonsistemi.Controllers
{
    public class BusListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
