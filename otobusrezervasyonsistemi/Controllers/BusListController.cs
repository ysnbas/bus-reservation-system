using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using otobusrezervasyonsistemi.Models;

namespace otobusrezervasyonsistemi.Controllers
{
    public class BusListController : Controller
    {
        private readonly MyDbContext _dbContext;

        public BusListController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Buses> bus = _dbContext.Buses.ToList();
            return View(bus);
        }
    }
}
