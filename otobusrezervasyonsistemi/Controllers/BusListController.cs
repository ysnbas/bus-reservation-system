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
            List<Routes> routes = _dbContext.Routes.ToList();
            return View(routes);
        }
    }
}
