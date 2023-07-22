using Microsoft.AspNetCore.Mvc;

namespace otobusrezervasyonsistemi.Controllers
{
    public class MyTicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
