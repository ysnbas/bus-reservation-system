using Microsoft.AspNetCore.Mvc;
using otobusrezervasyonsistemi.Models;

namespace otobusrezervasyonsistemi.Controllers
{
    public class TicketController : Controller
    {

        private readonly MyDbContext _dbContext;

        public TicketController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Tickets ticket)
        {

            if (ModelState.IsValid)
            {
                _dbContext.Tickets.Add(ticket);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "MyTicket");
            }
            return View();
        }

    }
}