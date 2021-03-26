using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ChekingSys.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        { 
            return View();
        }
    }
}
