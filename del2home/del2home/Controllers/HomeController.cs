using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using del2home.Models;

namespace del2home.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Home user)
        {
            if (ModelState.IsValid)
            {
                if(user.UserName == "test" && user.Password == "test")
                {
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "The user name or password is incorrect");
                    return View(user);
                }
            }
            return View(user);
        }

        public ActionResult LoggedIn()
        {
            return View();
        }

        public IActionResult Index()
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
