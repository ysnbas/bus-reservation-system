using Microsoft.AspNetCore.Mvc;
using otobusrezervasyonsistemi.Models;


namespace otobusrezervasyonsistemi.Controllers
{
    public class LogRegController : Controller
    {
        private readonly MyDbContext _dbContext;

        public LogRegController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Users modelLogin)
        {
            foreach (var item in _dbContext.Users)
                {

                    if (modelLogin.Username == item.Username &&
                    modelLogin.Password == item.Password
                    )
                    {
                        HttpContext.Response.Cookies.Append("username", item.Username);
                        HttpContext.Response.Cookies.Append("userId", item.id.ToString());
                        HttpContext.Response.Cookies.Append("userRole", item.isAdmin.ToString());
                        if (item.isAdmin == true)
                        {
                            return RedirectToAction("BusList", "Admin");
                        }
                        return RedirectToAction("Index", "BusList");
                    }
            }


            ViewData["ValidateMessage"] = "Kullanıcı adı veya parola yanlış";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Users modelRegister)
        {
            modelRegister.isAdmin = false;
            if (ModelState.IsValid)
            {
                _dbContext.Users.Add(modelRegister);
                await _dbContext.SaveChangesAsync();

                return View("Index", modelRegister);
            }
            return View("Index");
        }

        public async Task<IActionResult> LogOut()
        {
            Response.Cookies.Delete("username");
            Response.Cookies.Delete("userId");
            Response.Cookies.Delete("userRole");
            return RedirectToAction("Index", "LogReg");
        }

    }
}
