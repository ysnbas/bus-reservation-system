using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using otobusrezervasyonsistemi.Models;

namespace otobusrezervasyonsistemi.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyDbContext _dbContext;

        public AdminController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Routes> routes = _dbContext.Routes.ToList();
            return View(routes);
            
        }
        public IActionResult AddRoute()
        {
            var viewModel = new AddRouteViewModel
            {
                Buses = _dbContext.Buses.ToList(),
                Route = new Routes()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoute(AddRouteViewModel routes)
        {
            Console.WriteLine(routes);
            if (routes.Route!=null)
            {
                _dbContext.Routes.Add(routes.Route);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Admin");
            }

            var viewModel = new AddRouteViewModel
            {
                Buses = _dbContext.Buses.ToList(),
                Route = routes.Route
            };

            return View(viewModel);
        }
        public IActionResult AddBus()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBus(Buses buses)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Buses.Add(buses);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("BusList", "Admin");
            }
            return View();
        }
        public IActionResult BusList()
        {
            List<Buses> bus = _dbContext.Buses.ToList();
            return View(bus);
        }
        public async Task<IActionResult> EditBus(int? id)
        {
            if (id == null || _dbContext.Buses == null)
            {
                return NotFound();
            }

            var buses = await _dbContext.Buses.FindAsync(id);
            if (buses == null)
            {
                return NotFound();
            }
            return View(buses);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBus(Buses buses)
        {
            if (ModelState.IsValid)
            {
             
               _dbContext.Update(buses);
               await _dbContext.SaveChangesAsync();

               return RedirectToAction("BusList", "Admin");
            }
            return View(buses);
        }

        public async Task<IActionResult> EditRoute(int? id)
        {
            if (id == null || _dbContext.Routes == null)
            {
                return NotFound();
            }

            var routes = await _dbContext.Routes.FindAsync(id);
            if (routes == null)
            {
                return NotFound();
            }
            return View(routes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRoute(Routes routes)
        {
            if (ModelState.IsValid)
            {

                _dbContext.Update(routes);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Admin");
            }
            return View(routes);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var buses = await _dbContext.Buses.FirstOrDefaultAsync(m => m.id == id);
            return View(buses);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteBus(int? id)
        {
            var bus = await _dbContext.Buses.FindAsync(id);
            if (bus == null)
            {
                return NotFound();
            }

            _dbContext.Buses.Remove(bus);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("BusList", "Admin");
        }
        public async Task<IActionResult> DeleteR(int id)
        {
            var routes = await _dbContext.Routes
                .FirstOrDefaultAsync(m => m.id == id);
            return View(routes);
        }

        [HttpPost, ActionName("DeleteR")]
        public async Task<IActionResult> DeleteRoute(int id)
        {
            var route = await _dbContext.Routes.FindAsync(id);
            if (route == null)
            {
                return NotFound();
            }

            _dbContext.Routes.Remove(route);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Admin");
        }
    }
}
