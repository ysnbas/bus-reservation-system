using Microsoft.AspNetCore.Mvc;
using otobusrezervasyonsistemi.Models;

namespace otobusrezervasyonsistemi.Controllers
{
    public class MyTicketController : Controller
    {
        private readonly MyDbContext _dbContext;

        public MyTicketController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Tickets> tickets = _dbContext.Tickets.ToList();
            return View(tickets);
        }
    }
}
