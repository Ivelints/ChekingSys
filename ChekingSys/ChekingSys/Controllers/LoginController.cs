using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ChekingSys.Data;
using ChekingSys.Models;

namespace ChekingSys.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _db;
        public LoginController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Login(int? id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login log)
        {
            var user=_db.Login.Where(x => x.Username == log.Username && x.Password == log.Password).Count();
            if (user > 0)
            {
                return RedirectToAction("Index", "Workers");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Dasboard()
        {
            return View();
        }
    }
}
