using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using multipleForm.Models;

namespace multipleForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly compDbContext db;

        public HomeController(compDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addemp(empDetail emp)
        {
            db.empDetails.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult adduser(userDetails user)
        {
            db.userDetails.Add(user);
            db.SaveChanges();
           
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}